namespace MediaPlayer.src.ErrorHelper
{
    public class ErrorHandler : Exception
    {
        private string _message;
        private int _errorCode;

        public ErrorHandler(string message, int errorCode)
        {
            _message = message;
            _errorCode = errorCode;
        }

        public static ErrorHandler FileExisted()
        {
            return new ErrorHandler("This file already exists.", 500);
        }

        public static ErrorHandler FileNotExist()
        {
            return new ErrorHandler("This file does not exist.",500);
        }
    }
}