
using design_pattern.AbstractFactory;
using design_pattern.Builder;
using design_pattern.Prototype;

#region 抽象工廠
//ICarFactory factory;

//Console.WriteLine("請輸入要生產的車種代號:");
//Console.WriteLine(@"1. 跑車
//2. 家庭車");

//string carNo = Console.ReadLine();

//switch (carNo)
//{
//    case "1":
//        factory = new SportsCarFactory();
//        break;
//    case "2":
//        factory = new FamilyCarFactory();
//        break;
//    default:
//        throw new Exception("無此車種");
//}

//ICar car = factory.CreateCar();
//Console.WriteLine($"生產 {car.GetCarType()} X 1");
#endregion
#region 原型模式
//ConcretePrototypeA prototypeA = new()
//{
//    x = 1,
//    y = 2,
//    Name = "ProtoTypeA"
//};
//Console.WriteLine(prototypeA.ToString());

//ConcretePrototypeA prototypeAClone = (ConcretePrototypeA)prototypeA.Clone();
//prototypeAClone.Name = "ProtoTypeAClone";
//Console.WriteLine(prototypeAClone.ToString());
#endregion
#region 創造者模式
Builder builder = new ConcreteBuilder();
Director.Construct(builder);

var house = builder.GetProduct();

Console.WriteLine(house.ToString());
#endregion
Console.ReadKey();