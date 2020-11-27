using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FromMySqlToMssSql.Models
{
    public partial class KillSomeTimeContext : DbContext
    {
        public KillSomeTimeContext()
        {
        }

        public KillSomeTimeContext(DbContextOptions<KillSomeTimeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<CopyrightReports> CopyrightReports { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Feedbacks> Feedbacks { get; set; }
        public virtual DbSet<FooterPages> FooterPages { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<MemeCategories> MemeCategories { get; set; }
        public virtual DbSet<MemeCommentRatings> MemeCommentRatings { get; set; }
        public virtual DbSet<MemeComments> MemeComments { get; set; }
        public virtual DbSet<MemeRatings> MemeRatings { get; set; }
        public virtual DbSet<MemeSections> MemeSections { get; set; }
        public virtual DbSet<MemeTags> MemeTags { get; set; }
        public virtual DbSet<MemeViews> MemeViews { get; set; }
        public virtual DbSet<Memes> Memes { get; set; }
        public virtual DbSet<MetaData> MetaData { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<RedirectLists> RedirectLists { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<RoleClaims> RoleClaims { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<UserClaims> UserClaims { get; set; }
        public virtual DbSet<UserLogins> UserLogins { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<UserTokens> UserTokens { get; set; }
        public virtual DbSet<VideoCategories> VideoCategories { get; set; }
        public virtual DbSet<VideoCommentRatings> VideoCommentRatings { get; set; }
        public virtual DbSet<VideoComments> VideoComments { get; set; }
        public virtual DbSet<VideoRatings> VideoRatings { get; set; }
        public virtual DbSet<VideoSections> VideoSections { get; set; }
        public virtual DbSet<VideoTags> VideoTags { get; set; }
        public virtual DbSet<VideoViews> VideoViews { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.0.140;Database=KillSomeTime;User=sa;Password=q123456q;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.IsAdmin)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.HasIndex(e => e.AuthorId);

                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.BlogsAuthor)
                    .HasForeignKey(d => d.AuthorId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BlogsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.BlogsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);
            });

            modelBuilder.Entity<CopyrightReports>(entity =>
            {
                entity.HasIndex(e => e.MemeId);

                entity.HasIndex(e => e.VideoId);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.CopyrightReports)
                    .HasForeignKey(d => d.MemeId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.CopyrightReports)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key)
                    .HasName("CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Feedbacks>(entity =>
            {
                entity.HasIndex(e => e.AuthorId);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.AuthorId);
            });

            modelBuilder.Entity<FooterPages>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.HasIndex(e => new { e.StateName, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<MemeCategories>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MemeCategoriesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MemeCategoriesUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);
            });

            modelBuilder.Entity<MemeCommentRatings>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.MemeCommentId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MemeCommentRatingsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.MemeComment)
                    .WithMany(p => p.MemeCommentRatings)
                    .HasForeignKey(d => d.MemeCommentId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MemeCommentRatingsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MemeCommentRatingsUser)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<MemeComments>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.MemeId);

                entity.HasIndex(e => e.ReplyToId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MemeCommentsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.MemeComments)
                    .HasForeignKey(d => d.MemeId);

                entity.HasOne(d => d.ReplyTo)
                    .WithMany(p => p.InverseReplyTo)
                    .HasForeignKey(d => d.ReplyToId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MemeCommentsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MemeCommentsUser)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<MemeRatings>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.MemeId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MemeRatingsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.MemeRatings)
                    .HasForeignKey(d => d.MemeId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MemeRatingsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MemeRatingsUser)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<MemeSections>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MemeSectionsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MemeSectionsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);
            });

            modelBuilder.Entity<MemeTags>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.MemeId);

                entity.HasIndex(e => e.TagId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MemeTagsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.MemeTags)
                    .HasForeignKey(d => d.MemeId);

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.MemeTags)
                    .HasForeignKey(d => d.TagId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MemeTagsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);
            });

            modelBuilder.Entity<MemeViews>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.MemeId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MemeViewsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.MemeViews)
                    .HasForeignKey(d => d.MemeId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MemeViewsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);
            });

            modelBuilder.Entity<Memes>(entity =>
            {
                entity.HasIndex(e => e.AuthorId);

                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.Id);

                entity.HasIndex(e => e.MemeCategoryId);

                entity.HasIndex(e => e.MemeSectionId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.MemesAuthor)
                    .HasForeignKey(d => d.AuthorId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MemesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.MemeCategory)
                    .WithMany(p => p.Memes)
                    .HasForeignKey(d => d.MemeCategoryId);

                entity.HasOne(d => d.MemeSection)
                    .WithMany(p => p.Memes)
                    .HasForeignKey(d => d.MemeSectionId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MemesUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasIndex(e => e.MemeCommentId);

                entity.HasIndex(e => e.MemeId);

                entity.HasIndex(e => e.RecieverId);

                entity.HasIndex(e => e.SenderId);

                entity.HasIndex(e => e.VideoCommentId);

                entity.HasIndex(e => e.VideoId);

                entity.HasOne(d => d.MemeComment)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.MemeCommentId);

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.MemeId);

                entity.HasOne(d => d.Reciever)
                    .WithMany(p => p.NotificationsReciever)
                    .HasForeignKey(d => d.RecieverId);

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.NotificationsSender)
                    .HasForeignKey(d => d.SenderId);

                entity.HasOne(d => d.VideoComment)
                    .WithMany(p => p.NotificationsVideoComment)
                    .HasForeignKey(d => d.VideoCommentId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.NotificationsVideo)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<Partners>(entity =>
            {
                entity.Property(e => e.Deleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");
            });

            modelBuilder.Entity<RedirectLists>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RedirectListsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.RedirectListsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasIndex(e => e.AuthorId);

                entity.HasIndex(e => e.MemeId);

                entity.HasIndex(e => e.VideoId);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.AuthorId);

                entity.HasOne(d => d.Meme)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.MemeId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<RoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat)
                    .HasName("IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score })
                    .HasName("IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TagsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TagsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);
            });

            modelBuilder.Entity<UserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.ClaimValue).IsRequired();

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Discriminator).HasMaxLength(450);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<UserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.Discriminator).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<VideoCategories>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VideoCategoriesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.VideoCategoriesUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);
            });

            modelBuilder.Entity<VideoCommentRatings>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.VideoCommentId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VideoCommentRatingsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.VideoCommentRatingsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideoCommentRatingsUser)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.VideoComment)
                    .WithMany(p => p.VideoCommentRatings)
                    .HasForeignKey(d => d.VideoCommentId);
            });

            modelBuilder.Entity<VideoComments>(entity =>
            {
                entity.HasIndex(e => e.AuthorId);

                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.ReplyToId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasIndex(e => e.VideoId);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.VideoCommentsAuthor)
                    .HasForeignKey(d => d.AuthorId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VideoCommentsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.ReplyTo)
                    .WithMany(p => p.InverseReplyTo)
                    .HasForeignKey(d => d.ReplyToId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.VideoCommentsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoComments)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<VideoRatings>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.VideoId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VideoRatingsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.VideoRatingsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideoRatingsUser)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoRatings)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<VideoSections>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VideoSectionsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.VideoSectionsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);
            });

            modelBuilder.Entity<VideoTags>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.TagId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasIndex(e => e.VideoId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VideoTagsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.VideoTags)
                    .HasForeignKey(d => d.TagId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.VideoTagsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoTags)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<VideoViews>(entity =>
            {
                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasIndex(e => e.VideoId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VideoViewsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.VideoViewsUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoViews)
                    .HasForeignKey(d => d.VideoId);
            });

            modelBuilder.Entity<Videos>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.CreatedByNavigationId);

                entity.HasIndex(e => e.UpdatedByNavigationId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.VideoSectionId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VideosCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedByNavigationId);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.VideosUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedByNavigationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideosUser)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.VideoSection)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.VideoSectionId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
