class Program
{
    static void Main(string[] args)
    {
        World world = new World("Test World");
        
        GameObject player = new GameObject("Player");

        player.AddComponent<Cuboid>();
        player.GetComponent<Cuboid>(); //what i can do rn
        //player.GetComponent<Cuboid>().y; // what i need to be able to do
        Console.WriteLine(player.GetComponent<Cuboid>());

        Camera camera = (Camera)player.GetComponent<Camera>();


        world.AddObject(player);
    }
}