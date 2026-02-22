using graft.nuget.HelloChessService;

namespace HelloChessConsumer;
public class HelloChessGraftConsumer
{
       public string CallSayHelloChess()
       {
	       return HelloChessService.SayHelloChess();
       }
}
