using RemontRequestApp.Models;

namespace RemontRequestApp.Classes.Connection
{
    static class Connecting
    {
        public static RemontRequestEntities entities {  get; set; } = new RemontRequestEntities();
    }
}
