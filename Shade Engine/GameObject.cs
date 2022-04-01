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

    public bool AddComponent<T>() where T : Component, new()
    {
        for (int i = 0; i < components.Count; i++)
        {
            if (typeof(T) == components[i].GetType())
            {
                Logger.LogLine($"Error: Component {typeof(T)} Is Already Connected To Object {name}", ConsoleColor.DarkRed);
                return false;
            }
        }
        components.Add(new T());
        Logger.LogLine($"Component {typeof(T)} Was Successfully Added To Object {name}", ConsoleColor.Green);
        return true;
    }

    public Component GetComponent<T>() where T : Component, new()
    {
        for (int i = 0; i < components.Count; i++)
        {
            if (typeof(T) == components[i].GetType())
            {
                return components[i];
            }
        }
        return new T();
    }
}