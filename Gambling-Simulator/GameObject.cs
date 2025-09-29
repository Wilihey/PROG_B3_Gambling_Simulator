namespace Gambling_Simulator
{
    public class GameObject
    {
        private Component[] _components = new Component[8];

        public TYPE GetComponent<TYPE>() where TYPE : Component
        {
            TYPE result_component = null;

            for (int component_index = 0; component_index < _components.Length; component_index++)
            {
                if (_components[component_index] != null)
                {
                    result_component = _components[component_index] as TYPE;

                    if (result_component != null)
                    {
                        break;
                    }
                }
            }

            return result_component;
        }

        public void AddComponent(Component component)
        {
            for (int component_index = 0; component_index < _components.Length; component_index++)
            {
                if (_components[component_index] == null)
                {
                    _components[component_index] = component;
                    break;
                }
            }
        }

        public virtual void Update(float elapsed_time)
        {
            for (int component_index = 0; component_index < _components.Length; component_index++)
            {
                if (_components[component_index] != null)
                {
                    _components[component_index].Update(elapsed_time);
                }
            }
        }

        public virtual void Start()
        {

        }

    }
}
