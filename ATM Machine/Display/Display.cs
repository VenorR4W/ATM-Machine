using System;

namespace Display
{
    public class Screen
    {
        private int SelectedIndex;
        private string Prompt;
        private string[] menu = {"Login","Check Balance","Deposit","Withdraw","Exit"};

        static public void Banner(){
                Console.WriteLine(@"   
                                       █████╗ ████████╗███╗   ███╗    ███╗   ███╗ █████╗  ██████╗██╗  ██╗██╗███╗   ██╗███████╗
                                      ██╔══██╗╚══██╔══╝████╗ ████║    ████╗ ████║██╔══██╗██╔════╝██║  ██║██║████╗  ██║██╔════╝
                                      ███████║   ██║   ██╔████╔██║    ██╔████╔██║███████║██║     ███████║██║██╔██╗ ██║█████╗  
                                      ██╔══██║   ██║   ██║╚██╔╝██║    ██║╚██╔╝██║██╔══██║██║     ██╔══██║██║██║╚██╗██║██╔══╝  
                                      ██║  ██║   ██║   ██║ ╚═╝ ██║    ██║ ╚═╝ ██║██║  ██║╚██████╗██║  ██║██║██║ ╚████║███████╗
                                      ╚═╝  ╚═╝   ╚═╝   ╚═╝     ╚═╝    ╚═╝     ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝╚══════╝
                                                                                        ");
        }
    }
}