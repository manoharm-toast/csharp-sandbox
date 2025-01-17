namespace xyz.middleware
{
    class MiddleWare
    {
        public void consoleWrite(dynamic value){
            Console.WriteLine(value);
        }
        public void FirstMethod(string name)
        {
            consoleWrite($"this my first method : {name}");
        }

        public void SecondMethod(string name)
        {
            consoleWrite($"this my second method : {name}");
        }

        
        public void Wrapper(Action function){
            consoleWrite("starts here");
            function();
            consoleWrite("ends here");
        }

        public void Try(string param1 ,Action<string> function){
            function(param1);
        }


         public void main(){
            Wrapper(() => {
                FirstMethod("Smith");
                SecondMethod("Steve");
            });

            Try("mano", (name) => {
                FirstMethod(name);
                SecondMethod(name);
            });
        }
    }
}