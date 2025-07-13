using Eduverse.Model.Entities.BankTasks;
using Eduverse.Model.Entities.Users;
using Eduverse.Model.Entities.ZeroCode;
using Microsoft.EntityFrameworkCore;

namespace Eduverse.DAL
{
    public class EduverseContext : DbContext
    {
        public EduverseContext(DbContextOptions<EduverseContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<AnswerAccordance> AnswerAccordances { get; set; }
        public DbSet<AnswerCheck> AnswerChecks { get; set; }
        public DbSet<AnswerRadio> AnswerRadios { get; set; }
        public DbSet<AnswerText> AnswerTexts { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankModule> BankModules { get; set; }
        public DbSet<BankTest> BankTests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AccordanceBox> AccordanceBoxes { get; set; }
        public DbSet<CheckBox> CheckBoxs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseRight> CoursesRight { get; set; }
        public DbSet<Model.Entities.ZeroCode.File> Files { get; set; }
        public DbSet<Grid> Grids { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleRight> ModuleRights { get; set; }
        public DbSet<RadioBox> RadioBoxes { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Text> Texts { get; set; }
        public DbSet<TextBox> TextsBoxes { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
