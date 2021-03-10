using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.OldModels
{
    public partial class killsometimeContext : DbContext
    {
        public killsometimeContext()
        {
        }

        public killsometimeContext(DbContextOptions<killsometimeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CopyrightReport> CopyrightReport { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Meme> Meme { get; set; }
        public virtual DbSet<MemeCategory> MemeCategory { get; set; }
        public virtual DbSet<MemeComment> MemeComment { get; set; }
        public virtual DbSet<MemeRating> MemeRating { get; set; }
        public virtual DbSet<MemeTag> MemeTag { get; set; }
        public virtual DbSet<MigrationVersions> MigrationVersions { get; set; }
        public virtual DbSet<RedirectList> RedirectList { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Video> Video { get; set; }
        public virtual DbSet<VideoCategory> VideoCategory { get; set; }
        public virtual DbSet<VideoComment> VideoComment { get; set; }
        public virtual DbSet<VideoRating> VideoRating { get; set; }
        public virtual DbSet<VideoTag> VideoTag { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=4021;database=killsometime;uid=user;pwd=Password_1234;convertzerodatetime=true", x => x.ServerVersion("8.0.23-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CopyrightReport>(entity =>
            {
                entity.ToTable("copyright_report");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("IDX_82886A07F675F31B");

                entity.HasIndex(e => e.Email)
                    .HasName("UNIQ_82886A07E7927C74")
                    .IsUnique();

                entity.HasIndex(e => e.MemeId)
                    .HasName("IDX_82886A07DB6EC45D");

                entity.HasIndex(e => e.VideoId)
                    .HasName("IDX_82886A0729C1004E");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescriptionCopyrightWork)
                    .IsRequired()
                    .HasColumnName("description_copyright_work")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.DescriptionInfringement)
                    .IsRequired()
                    .HasColumnName("description_infringement")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.IsSolved).HasColumnName("is_solved");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Links)
                    .IsRequired()
                    .HasColumnName("links")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MemeId).HasColumnName("meme_id");

                entity.Property(e => e.Organization)
                    .HasColumnName("organization")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.OwnerFullName)
                    .IsRequired()
                    .HasColumnName("owner_full_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phone_number")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PostLink)
                    .IsRequired()
                    .HasColumnName("post_link")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.CopyrightReport)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_82886A07F675F31B");

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.CopyrightReport)
                    .HasForeignKey(d => d.MemeId)
                    .HasConstraintName("FK_82886A07DB6EC45D");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.CopyrightReport)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_82886A0729C1004E");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("feedback");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("IDX_D2294458F675F31B");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_D2294458F675F31B");
            });

            modelBuilder.Entity<Meme>(entity =>
            {
                entity.ToTable("meme");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("IDX_4B9F7934F675F31B");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IDX_4B9F793412469DE2");

                entity.HasIndex(e => e.SectionId)
                    .HasName("IDX_4B9F7934D823E37A");

                entity.HasIndex(e => e.Slug)
                    .HasName("UNIQ_4B9F7934989D9B62")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.ChangedSectionAt)
                    .HasColumnName("changed_section_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FeaturedIndex).HasColumnName("featured_index");

                entity.Property(e => e.IsHidden).HasColumnName("is_hidden");

                entity.Property(e => e.MemePath)
                    .HasColumnName("meme_path")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("meta_description")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaFacebookDescription)
                    .HasColumnName("meta_facebook_description")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaFacebookTitle)
                    .HasColumnName("meta_facebook_title")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("meta_keywords")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaTwitterDescription)
                    .HasColumnName("meta_twitter_description")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaTwitterTitle)
                    .HasColumnName("meta_twitter_title")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.SectionId).HasColumnName("section_id");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Views).HasColumnName("views");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Meme)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_4B9F7934F675F31B");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Meme)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_4B9F793412469DE2");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Meme)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_4B9F7934D823E37A");
            });

            modelBuilder.Entity<MemeCategory>(entity =>
            {
                entity.ToTable("meme_category");

                entity.HasIndex(e => e.Slug)
                    .HasName("UNIQ_9451BBBE989D9B62")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MemeComment>(entity =>
            {
                entity.ToTable("meme_comment");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("IDX_5B58B6A0F675F31B");

                entity.HasIndex(e => e.MemeId)
                    .HasName("IDX_5B58B6A0DB6EC45D");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IDX_5B58B6A0727ACA70");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DownVotes)
                    .HasColumnName("down_votes")
                    .HasColumnType("longtext")
                    .HasComment("(DC2Type:array)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MemeId).HasColumnName("meme_id");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpVotes)
                    .HasColumnName("up_votes")
                    .HasColumnType("longtext")
                    .HasComment("(DC2Type:array)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.MemeComment)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_5B58B6A0F675F31B");

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.MemeComment)
                    .HasForeignKey(d => d.MemeId)
                    .HasConstraintName("FK_5B58B6A0DB6EC45D");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_5B58B6A0727ACA70");
            });

            modelBuilder.Entity<MemeRating>(entity =>
            {
                entity.ToTable("meme_rating");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("IDX_4EF87314F675F31B");

                entity.HasIndex(e => e.MemeId)
                    .HasName("IDX_4EF87314DB6EC45D");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemeId).HasColumnName("meme_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Vote).HasColumnName("vote");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.MemeRating)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_4EF87314F675F31B");

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.MemeRating)
                    .HasForeignKey(d => d.MemeId)
                    .HasConstraintName("FK_4EF87314DB6EC45D");
            });

            modelBuilder.Entity<MemeTag>(entity =>
            {
                entity.HasKey(e => new { e.MemeId, e.TagId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("meme_tag");

                entity.HasIndex(e => e.MemeId)
                    .HasName("IDX_7D5C9C9DDB6EC45D");

                entity.HasIndex(e => e.TagId)
                    .HasName("IDX_7D5C9C9DBAD26311");

                entity.Property(e => e.MemeId).HasColumnName("meme_id");

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.MemeTag)
                    .HasForeignKey(d => d.MemeId)
                    .HasConstraintName("FK_7D5C9C9DDB6EC45D");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.MemeTag)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_7D5C9C9DBAD26311");
            });

            modelBuilder.Entity<MigrationVersions>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PRIMARY");

                entity.ToTable("migration_versions");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("varchar(14)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ExecutedAt)
                    .HasColumnName("executed_at")
                    .HasColumnType("datetime")
                    .HasComment("(DC2Type:datetime_immutable)");
            });

            modelBuilder.Entity<RedirectList>(entity =>
            {
                entity.ToTable("redirect_list");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromUrl)
                    .IsRequired()
                    .HasColumnName("from_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ToUrl)
                    .HasColumnName("to_url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("report");

                entity.HasIndex(e => e.ActionTakenById)
                    .HasName("IDX_C42F77846C229D32");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("IDX_C42F7784F675F31B");

                entity.HasIndex(e => e.MemeId)
                    .HasName("IDX_C42F7784DB6EC45D");

                entity.HasIndex(e => e.VideoId)
                    .HasName("IDX_C42F778429C1004E");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionTaken)
                    .HasColumnName("action_taken")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ActionTakenById).HasColumnName("action_taken_by_id");

                entity.Property(e => e.Archive)
                    .HasColumnName("archive")
                    .HasColumnType("longtext")
                    .HasComment("(DC2Type:array)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MemeId).HasColumnName("meme_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.HasOne(d => d.ActionTakenBy)
                    .WithMany(p => p.ReportActionTakenBy)
                    .HasForeignKey(d => d.ActionTakenById)
                    .HasConstraintName("FK_C42F77846C229D32");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.ReportAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_C42F7784F675F31B");

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.MemeId)
                    .HasConstraintName("FK_C42F7784DB6EC45D");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_C42F778429C1004E");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("section");

                entity.HasIndex(e => e.Slug)
                    .HasName("UNIQ_2D737AEF989D9B62")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("tag");

                entity.HasIndex(e => e.Slug)
                    .HasName("UNIQ_389B783989D9B62")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.Email)
                    .HasName("UNIQ_8D93D649E7927C74")
                    .IsUnique();

                entity.HasIndex(e => e.Username)
                    .HasName("UNIQ_8D93D649F85E0677")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Bio)
                    .HasColumnName("bio")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MemesLimitPerDay).HasColumnName("memes_limit_per_day");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResetToken)
                    .HasColumnName("reset_token")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResetTokenExpiresAt).HasColumnName("reset_token_expires_at");

                entity.Property(e => e.Roles)
                    .IsRequired()
                    .HasColumnName("roles")
                    .HasColumnType("longtext")
                    .HasComment("(DC2Type:array)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.VideosLimitPerDay).HasColumnName("videos_limit_per_day");
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable("video");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("IDX_7CC7DA2CF675F31B");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IDX_7CC7DA2C12469DE2");

                entity.HasIndex(e => e.SectionId)
                    .HasName("IDX_7CC7DA2CD823E37A");

                entity.HasIndex(e => e.Slug)
                    .HasName("UNIQ_7CC7DA2C989D9B62")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.ChangedSectionAt)
                    .HasColumnName("changed_section_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FeaturedIndex).HasColumnName("featured_index");

                entity.Property(e => e.IsHidden).HasColumnName("is_hidden");

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("meta_description")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaFacebookDescription)
                    .HasColumnName("meta_facebook_description")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaFacebookTitle)
                    .HasColumnName("meta_facebook_title")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("meta_keywords")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaTitle)
                    .HasColumnName("meta_title")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaTwitterDescription)
                    .HasColumnName("meta_twitter_description")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MetaTwitterTitle)
                    .HasColumnName("meta_twitter_title")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.SectionId).HasColumnName("section_id");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ThumbnailPath)
                    .HasColumnName("thumbnail_path")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.VideoPath)
                    .HasColumnName("video_path")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.VideoType)
                    .HasColumnName("video_type")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Views).HasColumnName("views");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_7CC7DA2CF675F31B");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_7CC7DA2C12469DE2");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_7CC7DA2CD823E37A");
            });

            modelBuilder.Entity<VideoCategory>(entity =>
            {
                entity.ToTable("video_category");

                entity.HasIndex(e => e.Slug)
                    .HasName("UNIQ_AECE2B7D989D9B62")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VideoComment>(entity =>
            {
                entity.ToTable("video_comment");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("IDX_7199BBC1F675F31B");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IDX_7199BBC1727ACA70");

                entity.HasIndex(e => e.VideoId)
                    .HasName("IDX_7199BBC129C1004E");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DownVotes)
                    .HasColumnName("down_votes")
                    .HasColumnType("longtext")
                    .HasComment("(DC2Type:array)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpVotes)
                    .HasColumnName("up_votes")
                    .HasColumnType("longtext")
                    .HasComment("(DC2Type:array)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.VideoComment)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_7199BBC1F675F31B");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_7199BBC1727ACA70");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoComment)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_7199BBC129C1004E");
            });

            modelBuilder.Entity<VideoRating>(entity =>
            {
                entity.ToTable("video_rating");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("IDX_E0DE86EFF675F31B");

                entity.HasIndex(e => e.VideoId)
                    .HasName("IDX_E0DE86EF29C1004E");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.Vote).HasColumnName("vote");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.VideoRating)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_E0DE86EFF675F31B");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoRating)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_E0DE86EF29C1004E");
            });

            modelBuilder.Entity<VideoTag>(entity =>
            {
                entity.HasKey(e => new { e.VideoId, e.TagId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("video_tag");

                entity.HasIndex(e => e.TagId)
                    .HasName("IDX_F9107287BAD26311");

                entity.HasIndex(e => e.VideoId)
                    .HasName("IDX_F910728729C1004E");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.VideoTag)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_F9107287BAD26311");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoTag)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_F910728729C1004E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
