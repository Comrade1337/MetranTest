using System.Collections.Generic;

namespace MetranTest
{
    public enum States
    {
        WaitInput,
        Testing1,
        Testing2,
        Testing3,
        //etc
    }

    public static class State
    {
        static Dictionary<States, string> statusDic = new Dictionary<States, string>()
        {
            [States.WaitInput] = "Ожидается ввод",
            [States.Testing1] = "Тестирование #1",
            [States.Testing2] = "Тестирование #2",
            [States.Testing3] = "Тестирование #3",
        };

        static States Cur;
        static Form1 Form;

        /// <summary>
        /// Для установки состояния
        /// </summary>
        /// <param name="form"></param>
        public static void InitState(Form1 form)
        {
            Form = form;
        }

        public static States Current
        {
            get
            {
                return Cur;
            }
            set
            {
                Cur = value;

                Form.Status = statusDic[Cur];
            }
        }

    }
}
