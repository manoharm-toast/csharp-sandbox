namespace xyz.middleware
{
    class MiddleWare
    {
        public void consoleWrite(dynamic value){
            Console.WriteLine(value);
        }
        public void FirstMethod()
        {
            consoleWrite("this my first method");
        }

        public void SecondMethod()
        {
            consoleWrite("this my second method");
        }

       
        public void Wrapper(Action function){
            consoleWrite("starts here");
            function();
            consoleWrite("ends here");
        }

        public void Try(Action function){
            function();
        }


         public void main(){
            Try(() => Wrapper(FirstMethod));
            Try(() => Wrapper(SecondMethod));        
        }
    }
}