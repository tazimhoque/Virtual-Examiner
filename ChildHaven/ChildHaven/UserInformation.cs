using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildHaven
{
    class UserInformation
    {
         private static string QuizNo;
         private static string UserName;
         private static int QuestionNo;
         private static string OnlineOrOffline;
         private static string AllorSolved;

        public static void setQuizNo(string QN) 
        {
          
            QuizNo = QN;
      
         }

        public static void  setUserName(string UN) 
        {
        
           UserName = UN;
        }
        public static void setQuestionNO(int QN)
        {

            QuestionNo = QN;
        }

        public static void setOnlineOrOffline(string OnOf)
        {

            OnlineOrOffline = OnOf;
        }


        public static void setAllorSolved(string AS)
        {
            
            AllorSolved = AS;
        }


        


        public static string getQuizNo() 
         {
              return QuizNo;
         }

        public static string getUserName() 
        {
            return UserName;
        }

        public static int getQuestionNo()
        {
            return QuestionNo;
        }
        public static string getOnlineOrOffline()
        {
           
            return OnlineOrOffline;
        }
        public static string getAllorSolved()
        {
            
            return AllorSolved;
        }
        

    }
}
