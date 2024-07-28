using Microsoft.EntityFrameworkCore;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Queries.GetCommentsByBusiness
{
    public class GetCommentsByBusinessQuery : IGetCommentsByBusinessQuery
    {
     private readonly IDatabaseService _databaseService;

        public GetCommentsByBusinessQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<List<GetCommentsByBusinessModel>> Execute(int businessId)
        {
            var result = await (from comment in _databaseService.CommentEntity
                                join business in _databaseService.Business
                                on comment.BusinessId equals business.IdBusiness
                                join user in _databaseService.User
                                on comment.UserId equals user.IdUser
                                where comment.BusinessId == businessId
                                select new GetCommentsByBusinessModel
                                {
                                    IdComment = comment.IdComment,
                                    UserId = user.IdUser,
                                    BusinessId = business.IdBusiness,
                                    Comment = comment.Comment,
                                    UserName = user.UserName,
                                    BusinessName = business.Title
                                }).ToListAsync();
            return result;
        }
    }
}
