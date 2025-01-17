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

       
        //delegate is interface for function pointer
        public delegate void ToWrap();

        public void Wrapper(ToWrap function){
            consoleWrite("starts here");
            function();
            consoleWrite("ends here");
        }

         public void main(){
            Wrapper(FirstMethod);
            Wrapper(SecondMethod);
        }
    }
}