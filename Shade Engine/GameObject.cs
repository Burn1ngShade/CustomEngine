public class GameObject
{
    public string name;
    public Transform transform = new Transform();

    List<Component> components = new List<Component>();

    public GameObject(string Name)
    {
        name = Name;
        transform.position = Vector3.zero;
        transform.rotation = Vector3.zero;
        transform.scale = Vector3.one;
    }

    public GameObject(string Name, Vector3 Position)
    {
        name = Name;
        transform.position = Position;
        transform.rotation = Vector3.zero;
        transform.scale = Vector3.one;
    }

    public GameObject(string Name, Vector3 Position, Vector3 Rotation)
    {
        name = Name;
        transform.position = Position;
        transform.rotation = Rotation;
        transform.scale = Vector3.one;
    }

    public GameObject(string Name, Vector3 Position, Vector3 Rotation, Vector3 Scale)
    {
        name = Name;
        transform.position = Position;
        transform.rotation = Rotation;
        transform.scale = Scale;
    }

    public bool AddComponent(Component component)
    {
        for (int i = 0; i < components.Count; i++)
        {
            if (component.GetType() == components[i].GetType())
            {
                Logger.LogLine($"Error: Component {component.GetType()} Is Already Connected To Object {name}", ConsoleColor.DarkRed);
                return false;
            }
        }
        components.Add(component);
        Logger.LogLine($"Component {component.GetType()} Was Successfully Added To Object {name}", ConsoleColor.Green);
        return true;
    }

    public void GetComponent<T>() where T : Component
    {
        for (int i = 0; i < components.Count; i++)
        {
            if (EqualityComparer<T>){
                Logger.LogLine("YES IT WORKS");
            }
            else{
                Logger.LogLine($"{components[i]}")
            }
        }
    }
}