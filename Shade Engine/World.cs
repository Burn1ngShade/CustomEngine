class World
{
    string name;
    Dictionary<string, GameObject> objects = new Dictionary<string, GameObject>();

    public World(string Name)
    {
        name = Name;  
    }

    public bool AddObject(GameObject gameobject)
    {
        if (objects.ContainsKey(gameobject.name))
        {
            Logger.LogLine($"Error: An Object Of Name {gameobject.name} Is Already Defined In World {name}", ConsoleColor.DarkRed);
            return false;
        }

        objects.Add(gameobject.name, gameobject);
        Logger.LogLine($"Object {gameobject.name} Was Successfully Instantiated To Word {name}", ConsoleColor.Green);
        return true;
    }
}