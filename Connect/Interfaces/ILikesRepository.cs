using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connect.DTOs;
using Connect.Entities;
using Connect.Helpers;

namespace Connect.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams );
    }
}