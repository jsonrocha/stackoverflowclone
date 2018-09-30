﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using stackoverflowclone;

namespace stackoverflowclone.Migrations
{
    [DbContext(typeof(StackOverflowContext))]
    [Migration("20180930204357_AddedVotesController")]
    partial class AddedVotesController
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("stackoverflowclone.Models.AnswerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("DownVote");

                    b.Property<int>("QuestionModelId");

                    b.Property<int?>("UpVote");

                    b.HasKey("Id");

                    b.HasIndex("QuestionModelId");

                    b.ToTable("AnswersTable");
                });

            modelBuilder.Entity("stackoverflowclone.Models.QuestionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("DownVote");

                    b.Property<string>("Question");

                    b.Property<string>("Title");

                    b.Property<int?>("UpVote");

                    b.HasKey("Id");

                    b.ToTable("QuestionsTable");
                });

            modelBuilder.Entity("stackoverflowclone.Models.AnswerModel", b =>
                {
                    b.HasOne("stackoverflowclone.Models.QuestionModel", "QuestionModel")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
