using Eduverse.DAL.Repositories.Contracts.Bases;
using Eduverse.Model.Entities.Bases;
using Microsoft.EntityFrameworkCore.Storage;
using System.Transactions;

namespace Eduverse.DAL
{
    public class UnitOfWork<K> : IDisposable 
        where K : BaseEntity
    {
        private readonly EduverseContext _context;
        public UnitOfWork(EduverseContext context)
        {
            _context = context;
        }
        private bool isCommitted = false;
        private bool isRollbacked = false;
        public IDbContextTransaction Transaction;

        public IBaseRepository<K> GetRepository(Func<EduverseContext, IBaseRepository<K>> func)
        {
            return func(_context);
        }

        public void Commit()
        {
            if (isCommitted || isRollbacked)
            {
                throw new TransactionException("Transaction is committed or rollbacked");
            }
            _context.SaveChanges();
            Transaction.Commit();
        }

        public void Rollback()
        {
            if (isCommitted || isRollbacked)
            {
                throw new TransactionException("Transaction is committed or rollbacked");
            }
            Transaction.Rollback();
        }

        //public void BreakTransaction()
        //{
        //    isRollbacked = false;
        //    isCommitted = false;
        //}

        public virtual void Dispose()
        {
            if (!isCommitted && !isRollbacked)
            {
                Rollback();
            }
            Transaction.Dispose();
        }
    }
}
