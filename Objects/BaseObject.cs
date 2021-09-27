using System.Numerics;
using System.IO;
using Backend.States;

namespace Backend.Objects
{
   public class BaseObject
    {
        StateMachine stateMachine = new ();


        public int Id { get; set; }
        public string Name { get; set; }
        public Vector3 Position { get; set; }
        public Vector3 Rotation { get; set; }


        public void Start()
        {
            System.Console.WriteLine(this.ToString());
        }

        public void Update()
        {

        }

        public byte[] Serialize()
        {
            using MemoryStream memoryStream = new ();
            using BinaryWriter binaryWriter = new (memoryStream); 
            binaryWriter.Write(Id);
            binaryWriter.Write(Name);
            return memoryStream.ToArray();      
        }

        public static BaseObject Deserialize(byte[] data)
        {
            BaseObject result = new ();
            using MemoryStream memoryStream = new (data); 
            using BinaryReader binaryReader = new (memoryStream);        
            result.Id = binaryReader.ReadInt32();
            result.Name = binaryReader.ReadString();      
            return result;
        }


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Position: {Position}";
        }
    } 
}
