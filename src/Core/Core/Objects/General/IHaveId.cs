using System;

namespace GoldenEye.Shared.Core.Objects.General
{
    public interface IHaveId
    {
        object Id { get; }
    }

    public interface IHaveId<out T>: IHaveId
    {
        new T Id { get; }
    }

    public interface IHaveGuidId: IHaveId<Guid>
    {
    }

    public interface IHaveStringId: IHaveId<string>
    {
    }

    public interface IHaveIntId: IHaveId<int>
    {
    }
}
