using System;
using System.Collections.Generic;
using System.Text;

namespace JFSEPABlogPost.UnitTest.Exceptions
{
    class UserNotFoundException : Exception
    {
        public string Messages;

        public UserNotFoundException()
        {
            Messages = "User Not Found Exception";
        }
        public UserNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
