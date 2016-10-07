
namespace WindsorCastleTest
{
    public class Main
    {
        private IDependency1 object1;
        private IDependency2 object2;

        public Main(IDependency1 dependency1, IDependency2 dependency2)
        {
            object1 = dependency1;
            object2 = dependency2;
        }

        public void DoSomething()
        {
            object1.SomeObject = "Hello World";
            object2.SomeOtherObject = "Hello Mars";
        }
    }

    public interface IDependency1
    {
        object SomeObject { get; set; }
    }

    public interface IDependency2
    {
        object SomeOtherObject { get; set; }
    }

    public class Dependency1 : IDependency1
    {
        public object SomeObject { get; set; }
    }

    public class Dependency2 : IDependency2
    {
        public object SomeOtherObject { get; set; }
    }
}
