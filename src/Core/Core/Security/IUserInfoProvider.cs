namespace GoldenEye.Shared.Core.Security
{
    public interface IUserInfoProvider
    {
        IUserInfo UserInfo { set; }

        int? GetCurrenUserId();
    }
}
