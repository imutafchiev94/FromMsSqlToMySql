using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FromMySqlToMssSql.Models;
using FromMySqlToMssSql.OldModels;
using FromMySqlToMssSql.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace FromMySqlToMssSql.Controllers
{
    public class HomeController : Controller
    {
        private readonly KillSomeTimeContext _newDbContext;
        private readonly killsometimeContext _oldDbContext;
        //private readonly UserManager<AspNetUsers> _userManager;


        public HomeController(KillSomeTimeContext newDbContext, killsometimeContext oldDbContext/*, UserManager<AspNetUsers> userManager*/)
        {
            _newDbContext = newDbContext;
            _oldDbContext = oldDbContext;
            //_userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public void Transfer()
        {
            TransferUsers();
            TransferMemeCategory();
            TransferMemeSection();
            TransferMemes();
            //TransferTag();
            TransferMemeTag();
            TransferMemeComment();
            TransferMemeRating();
            TransferVideoCategory();
            TransferVideoSection();
            TransferVideo();
            TransferVideoTag();
            TransferVideoComment();
            TransferVideoRating();
            TransferFeedback();
            //TransferRedirects();
            //TransferReports();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task TransferUsers()
        {
            var oldUsers = _oldDbContext.User.ToList();
            var newUsers = _newDbContext.AspNetUsers.ToList();

            foreach (var oldUser in oldUsers)
            {
                var findUser = newUsers.FirstOrDefault(u => u.UserName == oldUser.Username);
                if (findUser == null)
                {
                    var newUser = new AspNetUsers()
                    {
                        Id = Guid.NewGuid().ToString(),
                        UserName = oldUser.Username,
                        NormalizedUserName = oldUser.Username.ToUpper(),
                        Email = oldUser.Email,
                        NormalizedEmail = oldUser.Email.ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = oldUser.Password,
                        Avatar = oldUser.Avatar,
                        Bio = oldUser.Bio,
                        Country = oldUser.Country,
                        FullName = oldUser.FullName,
                        UploadLimit = oldUser.MemesLimitPerDay,
                        Gender = oldUser.Gender,
                        IsDeleted = false,
                        DateOfBirth = oldUser.DateOfBirth,
                        CreatedAt = oldUser.CreatedAt,
                        UpdatedAt = oldUser.UpdatedAt,
                        SecurityStamp = Guid.NewGuid().ToString("D"),
                        ConcurrencyStamp = Guid.NewGuid().ToString(),
                        LevelId = 0,
                        ScrollDistance = 0,
                        TotalExperience = 0,
                        DaysInArow = 0,
                        TotalDaysSpent = 0,
                        TotalMinutesSpent = 0
                    };

                    if (oldUser.Roles.Contains("ADMIN") || oldUser.Roles.Contains("MODERATOR"))
                    {
                        newUser.IsAdmin = true;
                    }
                    else
                    {
                        newUser.IsAdmin = false;
                    }

                    _newDbContext.AspNetUsers.Add(newUser);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferMemeCategory()
        {
            var oldMemeCategories = _oldDbContext.MemeCategory.ToList();
            var newMemeCategories = _newDbContext.MemeCategories.ToList();

            foreach (var oldMemeCategory in oldMemeCategories)
            {
                var findMemeCategory = newMemeCategories.FirstOrDefault(mc => mc.Name == oldMemeCategory.Name);
                if (findMemeCategory == null)
                {
                    var newMemeCategory = new MemeCategories()
                    {
                        Name = oldMemeCategory.Name,
                        CreatedAt = oldMemeCategory.CreatedAt,
                        UpdatedAt = oldMemeCategory.UpdatedAt,
                        Image = oldMemeCategory.Image,
                        Slug = oldMemeCategory.Slug,
                        IsDeleted = false
                    };

                    _newDbContext.MemeCategories.Add(newMemeCategory);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferMemeSection()
        {
            var oldSections = _oldDbContext.Section.ToList();
            var newSections = _newDbContext.MemeSections.ToList();

            foreach (var oldSection in oldSections)
            {
                var findMemeSection = newSections.FirstOrDefault(ms => ms.Name == oldSection.Name);
                if (findMemeSection == null)
                {
                    var newSection = new MemeSections()
                    {
                        Name = oldSection.Name,
                        RatingNeeded = oldSection.Rating,
                        Time = oldSection.Time,
                        Priority = oldSection.Priority,
                        Slug = oldSection.Slug,
                        CreatedAt = oldSection.CreatedAt,
                        UpdatedAt = oldSection.UpdatedAt
                    };

                    _newDbContext.MemeSections.Add(newSection);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferMemes()
        {
            var oldMemes = _oldDbContext.Meme.ToList();
            var newMemes = _newDbContext.Memes.ToList();

            foreach (var oldMeme in oldMemes)
            {
                var findMeme = _newDbContext.Memes.FirstOrDefault(m => m.Slug == oldMeme.Slug);

                if (findMeme == null)
                {
                    var author = _newDbContext.AspNetUsers.FirstOrDefault(u => u.UserName == oldMeme.Author.Username);
                    var category = _newDbContext.MemeCategories.FirstOrDefault(mc => mc.Name == oldMeme.Category.Name);
                    var section = _newDbContext.MemeSections.FirstOrDefault(ms => ms.Name == oldMeme.Section.Name);

                    var newMeme = new Memes()
                    {
                        AuthorId = author.Id,
                        MemePath = oldMeme.MemePath,
                        Title = oldMeme.Title,
                        Description = oldMeme.Description,
                        Views = oldMeme.Views,
                        MemeCategoryId = category.Id,
                        Rating = oldMeme.Rating,
                        Slug = oldMeme.Slug,
                        CreatedAt = oldMeme.CreatedAt,
                        UpdatedAt = oldMeme.UpdatedAt,
                        MemeSectionId = section.Id,
                        FeatureIndex = oldMeme.FeaturedIndex
                    };

                    _newDbContext.Memes.Add(newMeme);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferTag()
        {
            var oldTags = _oldDbContext.Tag.ToList();
            var newTags = _newDbContext.Tags.ToList();

            foreach (var oldTag in oldTags)
            {
                var findTag = newTags.FirstOrDefault(t => t.Name == oldTag.Name);

                if (findTag == null)
                {
                    var newTag = new Tags()
                    {
                        Name = oldTag.Name,
                        Slug = oldTag.Slug,
                        CreatedAt = oldTag.CreatedAt,
                        UpdatedAt = oldTag.UpdatedAt,
                    };

                    _newDbContext.Tags.Add(newTag);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferMemeTag()
        {
            var oldMemeTags = _oldDbContext.MemeTag.Include(t => t.Tag).Include(m => m.Meme).ToList();
            var newMemeTags = _newDbContext.MemeTags.Include(t => t.Tag).ToList();
            var newTags = _newDbContext.Tags.ToList();
            var oldTags = _oldDbContext.Tag.ToList();

            foreach (var oldMemeTag in oldMemeTags)
            {
                var oldTag = oldTags.FirstOrDefault(t => t.Id == oldMemeTag.TagId);
                var newTag = newTags.FirstOrDefault(t => t.Name == oldTag.Name);
                var findMemeTag = newMemeTags.FirstOrDefault(mt => mt.Tag.Name == newTag.Name);

                if (findMemeTag == null)
                {
                    var meme = _newDbContext.Memes.FirstOrDefault(m => oldMemeTag.Meme.Title == m.Title);
                    var newMemeTag = new MemeTags()
                    {
                        TagId = newTag.Id,
                        MemeId = meme.Id
                    };

                    _newDbContext.MemeTags.Add(newMemeTag);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferMemeRating()
        {
            var oldMemeRatings = _oldDbContext.MemeRating.Include(mr => mr.Author).Include(mr => mr.Meme).ToList();
            var newMemeRatings = _newDbContext.MemeRatings.ToList();

            foreach (var oldMemeRating in oldMemeRatings)
            {

                if (oldMemeRating.AuthorId != null)
                {
                    var author = _newDbContext.AspNetUsers.FirstOrDefault(u => u.UserName == oldMemeRating.Author.Username);
                    var meme = _newDbContext.Memes.FirstOrDefault(m => m.Title == oldMemeRating.Meme.Title);
                    var findMemeRating = newMemeRatings.FirstOrDefault(mr =>
                        oldMemeRating.Author.Username == author.UserName && oldMemeRating.Meme.Title == meme.Title);
                    if (findMemeRating == null)
                    {
                        var newMemeRating = new MemeRatings()
                        {
                            MemeId = meme.Id,
                            UserId = author.Id,
                            Rate = oldMemeRating.Vote,
                            CreatedAt = oldMemeRating.CreatedAt,
                            UpdatedAt = oldMemeRating.UpdatedAt
                        };

                        _newDbContext.MemeRatings.Add(newMemeRating);
                        _newDbContext.SaveChanges();
                    }
                }
                else
                {
                    var author = "Anonymous";
                    var meme = _newDbContext.Memes.FirstOrDefault(m => m.Title == oldMemeRating.Meme.Title);
                    var findMemeRating = newMemeRatings.FirstOrDefault(mr =>
                        oldMemeRating.AuthorId == null && oldMemeRating.Meme.Title == meme.Title);
                    if (findMemeRating == null)
                    {
                        var newMemeRating = new MemeRatings()
                        {
                            MemeId = meme.Id,
                            UserId = null,
                            Rate = oldMemeRating.Vote,
                            CreatedAt = oldMemeRating.CreatedAt,
                            UpdatedAt = oldMemeRating.UpdatedAt
                        };

                        _newDbContext.MemeRatings.Add(newMemeRating);
                        _newDbContext.SaveChanges();
                    }
                }
            }
        }

        private void TransferMemeComment()
        {
            var oldMemeComments = _oldDbContext.MemeComment.Include(mr => mr.Author).Include(mr => mr.Meme).ToList();
            var newMemeComments = _newDbContext.MemeComments.ToList();

            foreach (var oldMemeComment in oldMemeComments)
            {
                var author = _newDbContext.AspNetUsers.FirstOrDefault(u => u.UserName == oldMemeComment.Author.Username);
                var meme = _newDbContext.Memes.FirstOrDefault(m => m.Title == oldMemeComment.Meme.Title);
                var findMemeComment = newMemeComments.FirstOrDefault(mr =>
                    oldMemeComment.Author.Username == author.UserName && oldMemeComment.Meme.Title == meme.Title);
                if (findMemeComment == null)
                {
                    var newMemeComment = new MemeComments()
                    {
                        MemeId = meme.Id,
                        UserId = author.Id,
                        Comment = oldMemeComment.Text,
                        CreatedAt = oldMemeComment.CreatedAt,
                        UpdatedAt = oldMemeComment.UpdatedAt
                    };

                    _newDbContext.MemeComments.Add(newMemeComment);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferFeedback()
        {
            var oldFeedbacks = _oldDbContext.Feedback.Include(f => f.Author).ToList();
            var newFeedbacks = _newDbContext.Feedbacks.ToList();

            foreach (var oldFeedback in oldFeedbacks)
            {
                var author = _newDbContext.AspNetUsers.FirstOrDefault(a => a.UserName == oldFeedback.Author.Username);
                var findFeedback = newFeedbacks.FirstOrDefault(f => f.Title == oldFeedback.Title && oldFeedback.Author.Username == author.UserName);
                if (findFeedback == null)
                {
                    var newFeedback = new Feedbacks()
                    {
                        AuthorId = author.Id,
                        Title = oldFeedback.Title,
                        Description = oldFeedback.Description,
                        CreatedAt = oldFeedback.CreatedAt
                    };

                    _newDbContext.Feedbacks.Add(newFeedback);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferRedirects()
        {
            var oldRedirects = _oldDbContext.RedirectList.ToList();
            var newRedirects = _newDbContext.RedirectLists.ToList();

            foreach (var oldRedirect in oldRedirects)
            {
                var findRedirect = newRedirects.FirstOrDefault(r => r.FromUrl == oldRedirect.FromUrl);
                if (findRedirect == null)
                {
                    var newRedirect = new RedirectLists()
                    {
                        FromUrl = oldRedirect.FromUrl,
                        ToUrl = oldRedirect.ToUrl,
                        CreatedAt = oldRedirect.CreatedAt,
                        UpdatedAt = oldRedirect.UpdatedAt
                    };

                    _newDbContext.RedirectLists.Add(newRedirect);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferVideoCategory()
        {
            var oldVideoCategories = _oldDbContext.VideoCategory.ToList();
            var newVideoCategories = _newDbContext.VideoCategories.ToList();

            foreach (var oldVideoCategory in oldVideoCategories)
            {
                var findVideoCategory = newVideoCategories.FirstOrDefault(vc => vc.Name == oldVideoCategory.Name);
                if (findVideoCategory == null)
                {
                    var newVideoCategory = new VideoCategories()
                    {
                        Name = oldVideoCategory.Name,
                        CreatedAt = oldVideoCategory.CreatedAt,
                        UpdatedAt = oldVideoCategory.UpdatedAt,
                        Image = oldVideoCategory.Image,
                        Slug = oldVideoCategory.Slug,
                        IsDeleted = false
                    };

                    _newDbContext.VideoCategories.Add(newVideoCategory);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferVideoSection()
        {
            var oldSections = _oldDbContext.Section.ToList();
            var newSections = _newDbContext.VideoSections.ToList();

            foreach (var oldSection in oldSections)
            {
                var findVideoSection = newSections.FirstOrDefault(ms => ms.Name == oldSection.Name);
                if (findVideoSection == null)
                {
                    var newSection = new VideoSections()
                    {
                        Name = oldSection.Name,
                        RatingNeeded = oldSection.Rating,
                        Time = oldSection.Time,
                        Priority = oldSection.Priority,
                        Slug = oldSection.Slug,
                        CreatedAt = oldSection.CreatedAt,
                        UpdatedAt = oldSection.UpdatedAt
                    };

                    _newDbContext.VideoSections.Add(newSection);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferVideo()
        {
            var oldVideos = _oldDbContext.Video.ToList();
            var newVideos = _newDbContext.Videos.ToList();

            foreach (var oldVideo in oldVideos)
            {
                var findVideo = _newDbContext.Videos.FirstOrDefault(m => m.Slug == oldVideo.Slug);

                if (findVideo == null)
                {
                    var author = _newDbContext.AspNetUsers.FirstOrDefault(u => u.UserName == oldVideo.Author.Username);
                    var category = _newDbContext.VideoCategories.FirstOrDefault(mc => mc.Name == oldVideo.Category.Name);
                    var section = _newDbContext.VideoSections.FirstOrDefault(ms => ms.Name == oldVideo.Section.Name);

                    var newVideo = new Videos()
                    {
                        UserId = author.Id,
                        VideoPath = oldVideo.VideoPath,
                        Title = oldVideo.Title,
                        Description = oldVideo.Description,
                        Views = oldVideo.Views,
                        Rating = oldVideo.Rating,
                        Slug = oldVideo.Slug,
                        CreatedAt = oldVideo.CreatedAt,
                        UpdatedAt = oldVideo.UpdatedAt,
                        VideoSectionId = section.Id,
                        FeatureIndex = oldVideo.FeaturedIndex
                    };

                    _newDbContext.Videos.Add(newVideo);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferVideoTag()
        {
            var oldVideoTags = _oldDbContext.VideoTag.Include(t => t.Tag).Include(m => m.Video).ToList();
            var newVideoTags = _newDbContext.VideoTags.Include(t => t.Tag).ToList();
            var newTags = _newDbContext.Tags.ToList();
            var oldTags = _oldDbContext.Tag.ToList();

            foreach (var oldVideoTag in oldVideoTags)
            {
                var oldTag = oldTags.FirstOrDefault(t => t.Id == oldVideoTag.TagId);
                var newTag = newTags.FirstOrDefault(t => t.Name == oldTag.Name);
                var findVideoTag = newVideoTags.FirstOrDefault(mt => mt.Tag.Name == newTag.Name);

                if (findVideoTag == null)
                {
                    var video = _newDbContext.Videos.FirstOrDefault(m => oldVideoTag.Video.Title == m.Title);
                    var newVideoTag = new VideoTags()
                    {
                        TagId = newTag.Id,
                        VideoId = video.Id
                    };

                    _newDbContext.VideoTags.Add(newVideoTag);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferVideoRating()
        {
            var oldVideoRatings = _oldDbContext.VideoRating.Include(mr => mr.Author).Include(mr => mr.Video).ToList();
            var newVideoRatings = _newDbContext.VideoRatings.ToList();

            foreach (var oldVideoRating in oldVideoRatings)
            {
                if (oldVideoRating.AuthorId != null)
                {
                    var author = _newDbContext.AspNetUsers.FirstOrDefault(u => u.UserName == oldVideoRating.Author.Username);
                    var video = _newDbContext.Videos.FirstOrDefault(m => m.Title == oldVideoRating.Video.Title);
                    var findVideoRating = newVideoRatings.FirstOrDefault(mr =>
                        oldVideoRating.Author.Username == author.UserName && oldVideoRating.Video.Title == video.Title);
                    if (findVideoRating == null)
                    {
                        var newVideoRating = new VideoRatings()
                        {
                            VideoId = video.Id,
                            UserId = author.Id,
                            Rate = oldVideoRating.Vote,
                            CreatedAt = oldVideoRating.CreatedAt,
                            UpdatedAt = oldVideoRating.UpdatedAt
                        };

                        _newDbContext.VideoRatings.Add(newVideoRating);
                        _newDbContext.SaveChanges();
                    }
                }
                else
                {
                    var author = "Anonymous";
                    var video = _newDbContext.Videos.FirstOrDefault(m => m.Title == oldVideoRating.Video.Title);
                    var findVideoRating = newVideoRatings.FirstOrDefault(mr =>
                        oldVideoRating.Author == null && oldVideoRating.Video.Title == video.Title);
                    if (findVideoRating == null)
                    {
                        var newVideoRating = new VideoRatings()
                        {
                            VideoId = video.Id,
                            UserId = null,
                            Rate = oldVideoRating.Vote,
                            CreatedAt = oldVideoRating.CreatedAt,
                            UpdatedAt = oldVideoRating.UpdatedAt
                        };

                        _newDbContext.VideoRatings.Add(newVideoRating);
                        _newDbContext.SaveChanges();
                    }
                }
                
            }
        }

        private void TransferVideoComment()
        {
            var oldVideoComments = _oldDbContext.VideoComment.Include(mr => mr.Author).Include(mr => mr.Video).ToList();
            var newVideoComments = _newDbContext.VideoComments.ToList();

            foreach (var oldVideoComment in oldVideoComments)
            {
                var author = _newDbContext.AspNetUsers.FirstOrDefault(u => u.UserName == oldVideoComment.Author.Username);
                var video = _newDbContext.Videos.FirstOrDefault(m => m.Title == oldVideoComment.Video.Title);
                var findVideoComment = newVideoComments.FirstOrDefault(mr =>
                    oldVideoComment.Author.Username == author.UserName && oldVideoComment.Video.Title == video.Title);
                if (findVideoComment == null)
                {
                    var newVideoComment = new VideoComments()
                    {
                        VideoId = video.Id,
                        AuthorId = author.Id,
                        Comment = oldVideoComment.Text,
                        CreatedAt = oldVideoComment.CreatedAt,
                        UpdatedAt = oldVideoComment.UpdatedAt
                    };

                    _newDbContext.VideoComments.Add(newVideoComment);
                    _newDbContext.SaveChanges();
                }
            }
        }

        private void TransferReports()
        {
            var oldReports = _oldDbContext.Report.Include(r => r.Meme).Include(r => r.Video).Include(r => r.Author).ToList();
            var newReports = _newDbContext.Reports.ToList();

            foreach (var oldReport in oldReports)
            {
                var author = _newDbContext.AspNetUsers.FirstOrDefault(u => u.UserName == oldReport.Author.Username);
                var video = _newDbContext.Videos.FirstOrDefault(m => m.Title == oldReport.Video.Title);
                var meme = _newDbContext.Memes.FirstOrDefault(m => m.Title == oldReport.Meme.Title);

                var newReport = new Reports()
                {
                    AuthorId = author.Id,
                    MemeId = meme.Id,
                    VideoId = video.Id,
                    Type = oldReport.Type,
                    Description = oldReport.Description,
                    Status = oldReport.ActionTaken,
                    CreatedAt = oldReport.CreatedAt
                };

                _newDbContext.Reports.Add(newReport);
                _newDbContext.SaveChanges();
            }
        }
    }
}
