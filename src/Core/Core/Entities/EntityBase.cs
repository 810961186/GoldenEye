using GoldenEye.Shared.Core.Objects.General;

namespace GoldenEye.Backend.Core.Entity
{
    public class EntityBase: IEntity
    {
        public virtual int Id { get; set; }

        object IHaveId.Id
        {
            get { return Id; }
        }
    }
}
