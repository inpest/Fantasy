using System;

namespace Fantasy
{
    public interface IAwakeSystem : IEntitiesSystem { }
    
    public abstract class AwakeSystem<T> : IAwakeSystem where T : Entity
    {
        public Type EntitiesType() => typeof(T);

        protected abstract void Awake(T entity);

        public void Invoke(Entity entity)
        {
            Awake((T) entity);
        }
    }
}