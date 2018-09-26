using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using stackoverflowclone.Models;

namespace stackoverflowclone
{
    public partial class StackOverflowContext : DbContext
    {
        public StackOverflowContext()
        {
        }

        public StackOverflowContext(DbContextOptions<StackOverflowContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("server=localhost;database=StackOverflow;username=postgres;password=warrior");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        public DbSet<AnswerModel> AnswersTable { get; set; }

        public DbSet<QuestionModel> QuestionsTable { get; set; }

        public DbSet<UserModel> UserTable { get; set; }
    }
}
