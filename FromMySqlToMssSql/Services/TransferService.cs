using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromMySqlToMssSql.Models;
using FromMySqlToMssSql.OldModels;
using FromMySqlToMssSql.Services.Interfaces;

namespace FromMySqlToMssSql.Services
{
    public class TransferService 
    {
        //private readonly KillSomeTimeContext _newDbContext;
        //private readonly killsometimeContext _oldDbContext;

        //public TransferService(KillSomeTimeContext newDbContext, killsometimeContext oldDbContext)
        //{
        //    _newDbContext = newDbContext;
        //    _oldDbContext = oldDbContext;
        //}
        //public void Transfer()
        //{
        //    TransferUsers();
        //    TransferMemeCategory();
        //    TransferMemeSection();
        //    TransferMemes();
        //}

        //private void TransferUsers()
        //{
        //    var oldUsers = _oldDbContext.Users.ToList();
        //    var newUsers = _newDbContext.AspNetUsers.ToList();

        //    foreach (var oldUser in oldUsers)
        //    {
        //        var findUser = newUsers.FirstOrDefault(u => u.UserName == oldUser.Username);
        //        if (findUser == null)
        //        {
        //            var newUser = new AspNetUsers()
        //            {
        //                UserName = oldUser.Username,
        //                NormalizedUserName = oldUser.Username.ToUpper(),
        //                Email = oldUser.Email,
        //                NormalizedEmail = oldUser.Email.ToUpper(),
        //                EmailConfirmed = true,
        //                PasswordHash = oldUser.Password,
        //                Avatar = oldUser.Avatar,
        //                Bio = oldUser.Bio,
        //                Country = oldUser.Country,
        //                FullName = oldUser.FullName,
        //                UploadLimit = oldUser.MemesLimitPerDay,
        //                Gender = oldUser.Gender,
        //                IsDeleted = false,
        //                //DateOfBirth = oldUser.DateOfBirth,
        //                //CreatedAt = oldUser.CreatedAt,
        //                //UpdatedAt = oldUser.UpdatedAt
        //            };

        //            if (oldUser.Roles.Contains("ADMIN") || oldUser.Roles.Contains("MODERATOR"))
        //            {
        //                newUser.IsAdmin = true;
        //            }
        //            else
        //            {
        //                newUser.IsAdmin = false;
        //            }

        //            _newDbContext.AspNetUsers.Add(newUser);
        //            _newDbContext.SaveChanges();
        //        }
        //    }
        //}

        //private void TransferMemeCategory()
        //{
        //    var oldMemeCategories = _oldDbContext.MemeCategories.ToList();
        //    var newMemeCategories = _newDbContext.MemeCategories.ToList();

        //    foreach (var oldMemeCategory in oldMemeCategories)
        //    {
        //        var findMemeCategory = newMemeCategories.FirstOrDefault(mc => mc.Name == oldMemeCategory.Name);
        //        if (findMemeCategory == null)
        //        {
        //            var newMemeCategory = new MemeCategories()
        //            {
        //                Name = oldMemeCategory.Name,
        //                //CreatedAt = oldMemeCategory.CreatedAt,
        //                //UpdatedAt = oldMemeCategory.UpdatedAt,
        //                Image = oldMemeCategory.Image,
        //                Slug = oldMemeCategory.Slug,
        //                IsDeleted = false
        //            };

        //            _newDbContext.MemeCategories.Add(newMemeCategory);
        //            _oldDbContext.SaveChanges();
        //        }
        //    }
        //}

        //private void TransferMemeSection()
        //{
        //    var oldSections = _oldDbContext.Sections.ToList();
        //    var newSections = _newDbContext.MemeSections.ToList();

        //    foreach (var oldSection in oldSections)
        //    {
        //        var newSection = new MemeSections()
        //        {
        //            Name = oldSection.Name,
        //            RatingNeeded = oldSection.Rating,
        //            Time = oldSection.Time,
        //            Priority = oldSection.Priority,
        //            Slug = oldSection.Slug,
        //            //CreatedAt = oldSection.CreatedAt,
        //            //UpdatedAt = oldSection.UpdatedAt
        //        };

        //        _newDbContext.MemeSections.Add(newSection);
        //        _newDbContext.SaveChanges();
        //    }
        //}

        //private void TransferMemes()
        //{
        //    var oldMemes = _oldDbContext.Memes.ToList();
        //    var newMemes = _newDbContext.Memes.ToList();

        //    foreach (var oldMeme in oldMemes)
        //    {
        //        var findMeme = _newDbContext.Memes.FirstOrDefault(m => m.Title == oldMeme.Title);

        //        if (findMeme == null)
        //        {
        //            var author = _newDbContext.AspNetUsers.FirstOrDefault(u => u.UserName == oldMeme.Author.Username);
        //            var category = _newDbContext.MemeCategories.FirstOrDefault(mc => mc.Name == oldMeme.Category.Name);
        //            var section = _newDbContext.MemeSections.FirstOrDefault(ms => ms.Name == oldMeme.Section.Name);

        //            var newMeme = new Memes()
        //            {
        //                AuthorId = author.Id,
        //                MemePath = oldMeme.MemePath,
        //                Title = oldMeme.Title,
        //                Description = oldMeme.Description,
        //                Views = oldMeme.Views,
        //                MemeCategoryId = category.Id,
        //                Rating = oldMeme.Rating,
        //                Slug = oldMeme.Slug,
        //                //CreatedAt = oldMeme.CreatedAt,
        //                //UpdatedAt = oldMeme.UpdatedAt,
        //                MemeSectionId = section.Id,
        //                FeatureIndex = oldMeme.FeaturedIndex
        //            };

        //            _newDbContext.Memes.Add(newMeme);
        //            _newDbContext.SaveChanges();
        //        }
        //    }
        //}
    }
}
