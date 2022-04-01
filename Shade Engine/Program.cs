class Program
{
    static void Main(string[] args)
    {
        World world = new World("Test World");
        
        GameObject player = new GameObject("Player");
        player.AddComponent(new Camera());
        player.AddComponent(new Camera());

        player.GetComponent<Camera>();

        world.AddObject(player);
    }
}