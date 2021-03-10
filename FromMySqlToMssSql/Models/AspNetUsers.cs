using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            Badges = new HashSet<Badges>();
            BlogsAuthor = new HashSet<Blogs>();
            BlogsCreatedByNavigation = new HashSet<Blogs>();
            BlogsUpdatedByNavigation = new HashSet<Blogs>();
            Feedbacks = new HashSet<Feedbacks>();
            GameRatingsCreatedByNavigation = new HashSet<GameRatings>();
            GameRatingsUpdatedByNavigation = new HashSet<GameRatings>();
            GameRatingsUser = new HashSet<GameRatings>();
            MemeCategoriesCreatedByNavigation = new HashSet<MemeCategories>();
            MemeCategoriesUpdatedByNavigation = new HashSet<MemeCategories>();
            MemeCommentRatingsCreatedByNavigation = new HashSet<MemeCommentRatings>();
            MemeCommentRatingsUpdatedByNavigation = new HashSet<MemeCommentRatings>();
            MemeCommentRatingsUser = new HashSet<MemeCommentRatings>();
            MemeCommentsCreatedByNavigation = new HashSet<MemeComments>();
            MemeCommentsUpdatedByNavigation = new HashSet<MemeComments>();
            MemeCommentsUser = new HashSet<MemeComments>();
            MemeRatingsCreatedByNavigation = new HashSet<MemeRatings>();
            MemeRatingsUpdatedByNavigation = new HashSet<MemeRatings>();
            MemeRatingsUser = new HashSet<MemeRatings>();
            MemeSectionsCreatedByNavigation = new HashSet<MemeSections>();
            MemeSectionsUpdatedByNavigation = new HashSet<MemeSections>();
            MemeTagsCreatedByNavigation = new HashSet<MemeTags>();
            MemeTagsUpdatedByNavigation = new HashSet<MemeTags>();
            MemeViewsCreatedByNavigation = new HashSet<MemeViews>();
            MemeViewsUpdatedByNavigation = new HashSet<MemeViews>();
            MemesAuthor = new HashSet<Memes>();
            MemesCreatedByNavigation = new HashSet<Memes>();
            MemesUpdatedByNavigation = new HashSet<Memes>();
            NotificationsReciever = new HashSet<Notifications>();
            NotificationsSender = new HashSet<Notifications>();
            RedirectListsCreatedByNavigation = new HashSet<RedirectLists>();
            RedirectListsUpdatedByNavigation = new HashSet<RedirectLists>();
            Reports = new HashSet<Reports>();
            TagsCreatedByNavigation = new HashSet<Tags>();
            TagsUpdatedByNavigation = new HashSet<Tags>();
            UserAchievements = new HashSet<UserAchievements>();
            UserBadges = new HashSet<UserBadges>();
            UserClaims = new HashSet<UserClaims>();
            UserFrames = new HashSet<UserFrames>();
            UserLogins = new HashSet<UserLogins>();
            UserTokens = new HashSet<UserTokens>();
            VideoCategoriesCreatedByNavigation = new HashSet<VideoCategories>();
            VideoCategoriesUpdatedByNavigation = new HashSet<VideoCategories>();
            VideoCommentRatingsCreatedByNavigation = new HashSet<VideoCommentRatings>();
            VideoCommentRatingsUpdatedByNavigation = new HashSet<VideoCommentRatings>();
            VideoCommentRatingsUser = new HashSet<VideoCommentRatings>();
            VideoCommentsAuthor = new HashSet<VideoComments>();
            VideoCommentsCreatedByNavigation = new HashSet<VideoComments>();
            VideoCommentsUpdatedByNavigation = new HashSet<VideoComments>();
            VideoRatingsCreatedByNavigation = new HashSet<VideoRatings>();
            VideoRatingsUpdatedByNavigation = new HashSet<VideoRatings>();
            VideoRatingsUser = new HashSet<VideoRatings>();
            VideoSectionsCreatedByNavigation = new HashSet<VideoSections>();
            VideoSectionsUpdatedByNavigation = new HashSet<VideoSections>();
            VideoTagsCreatedByNavigation = new HashSet<VideoTags>();
            VideoTagsUpdatedByNavigation = new HashSet<VideoTags>();
            VideoViewsCreatedByNavigation = new HashSet<VideoViews>();
            VideoViewsUpdatedByNavigation = new HashSet<VideoViews>();
            VideosCreatedByNavigation = new HashSet<Videos>();
            VideosUpdatedByNavigation = new HashSet<Videos>();
            VideosUser = new HashSet<Videos>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string Avatar { get; set; }
        public string Bio { get; set; }
        public string Country { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Discriminator { get; set; }
        public bool? IsAdmin { get; set; }
        public int UploadLimit { get; set; }
        public bool? IsDeleted { get; set; }
        public string AccountType { get; set; }
        public int? FrameId { get; set; }
        public int LevelId { get; set; }
        public double QualityRating { get; set; }
        public double ScrollDistance { get; set; }
        public int TotalExperience { get; set; }
        public int DaysInArow { get; set; }
        public int TotalDaysSpent { get; set; }
        public int TotalMinutesSpent { get; set; }

        public virtual ICollection<Badges> Badges { get; set; }
        public virtual ICollection<Blogs> BlogsAuthor { get; set; }
        public virtual ICollection<Blogs> BlogsCreatedByNavigation { get; set; }
        public virtual ICollection<Blogs> BlogsUpdatedByNavigation { get; set; }
        public virtual ICollection<Feedbacks> Feedbacks { get; set; }
        public virtual ICollection<GameRatings> GameRatingsCreatedByNavigation { get; set; }
        public virtual ICollection<GameRatings> GameRatingsUpdatedByNavigation { get; set; }
        public virtual ICollection<GameRatings> GameRatingsUser { get; set; }
        public virtual ICollection<MemeCategories> MemeCategoriesCreatedByNavigation { get; set; }
        public virtual ICollection<MemeCategories> MemeCategoriesUpdatedByNavigation { get; set; }
        public virtual ICollection<MemeCommentRatings> MemeCommentRatingsCreatedByNavigation { get; set; }
        public virtual ICollection<MemeCommentRatings> MemeCommentRatingsUpdatedByNavigation { get; set; }
        public virtual ICollection<MemeCommentRatings> MemeCommentRatingsUser { get; set; }
        public virtual ICollection<MemeComments> MemeCommentsCreatedByNavigation { get; set; }
        public virtual ICollection<MemeComments> MemeCommentsUpdatedByNavigation { get; set; }
        public virtual ICollection<MemeComments> MemeCommentsUser { get; set; }
        public virtual ICollection<MemeRatings> MemeRatingsCreatedByNavigation { get; set; }
        public virtual ICollection<MemeRatings> MemeRatingsUpdatedByNavigation { get; set; }
        public virtual ICollection<MemeRatings> MemeRatingsUser { get; set; }
        public virtual ICollection<MemeSections> MemeSectionsCreatedByNavigation { get; set; }
        public virtual ICollection<MemeSections> MemeSectionsUpdatedByNavigation { get; set; }
        public virtual ICollection<MemeTags> MemeTagsCreatedByNavigation { get; set; }
        public virtual ICollection<MemeTags> MemeTagsUpdatedByNavigation { get; set; }
        public virtual ICollection<MemeViews> MemeViewsCreatedByNavigation { get; set; }
        public virtual ICollection<MemeViews> MemeViewsUpdatedByNavigation { get; set; }
        public virtual ICollection<Memes> MemesAuthor { get; set; }
        public virtual ICollection<Memes> MemesCreatedByNavigation { get; set; }
        public virtual ICollection<Memes> MemesUpdatedByNavigation { get; set; }
        public virtual ICollection<Notifications> NotificationsReciever { get; set; }
        public virtual ICollection<Notifications> NotificationsSender { get; set; }
        public virtual ICollection<RedirectLists> RedirectListsCreatedByNavigation { get; set; }
        public virtual ICollection<RedirectLists> RedirectListsUpdatedByNavigation { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
        public virtual ICollection<Tags> TagsCreatedByNavigation { get; set; }
        public virtual ICollection<Tags> TagsUpdatedByNavigation { get; set; }
        public virtual ICollection<UserAchievements> UserAchievements { get; set; }
        public virtual ICollection<UserBadges> UserBadges { get; set; }
        public virtual ICollection<UserClaims> UserClaims { get; set; }
        public virtual ICollection<UserFrames> UserFrames { get; set; }
        public virtual ICollection<UserLogins> UserLogins { get; set; }
        public virtual ICollection<UserTokens> UserTokens { get; set; }
        public virtual ICollection<VideoCategories> VideoCategoriesCreatedByNavigation { get; set; }
        public virtual ICollection<VideoCategories> VideoCategoriesUpdatedByNavigation { get; set; }
        public virtual ICollection<VideoCommentRatings> VideoCommentRatingsCreatedByNavigation { get; set; }
        public virtual ICollection<VideoCommentRatings> VideoCommentRatingsUpdatedByNavigation { get; set; }
        public virtual ICollection<VideoCommentRatings> VideoCommentRatingsUser { get; set; }
        public virtual ICollection<VideoComments> VideoCommentsAuthor { get; set; }
        public virtual ICollection<VideoComments> VideoCommentsCreatedByNavigation { get; set; }
        public virtual ICollection<VideoComments> VideoCommentsUpdatedByNavigation { get; set; }
        public virtual ICollection<VideoRatings> VideoRatingsCreatedByNavigation { get; set; }
        public virtual ICollection<VideoRatings> VideoRatingsUpdatedByNavigation { get; set; }
        public virtual ICollection<VideoRatings> VideoRatingsUser { get; set; }
        public virtual ICollection<VideoSections> VideoSectionsCreatedByNavigation { get; set; }
        public virtual ICollection<VideoSections> VideoSectionsUpdatedByNavigation { get; set; }
        public virtual ICollection<VideoTags> VideoTagsCreatedByNavigation { get; set; }
        public virtual ICollection<VideoTags> VideoTagsUpdatedByNavigation { get; set; }
        public virtual ICollection<VideoViews> VideoViewsCreatedByNavigation { get; set; }
        public virtual ICollection<VideoViews> VideoViewsUpdatedByNavigation { get; set; }
        public virtual ICollection<Videos> VideosCreatedByNavigation { get; set; }
        public virtual ICollection<Videos> VideosUpdatedByNavigation { get; set; }
        public virtual ICollection<Videos> VideosUser { get; set; }
    }
}
