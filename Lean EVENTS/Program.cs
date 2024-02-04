using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Lean_EVENTS
{
    internal class Program
    {
        #region Аксессоры событий
        //// Создать специальные средства для управления списками
        //// вызова обработчиков событий.
        //// Объявить тип делегата для события.
        //delegate void MyEventHandler();

        //// Объявить класс для хранения максимум трех событий.
        //class MyEvent
        //{
        //    MyEventHandler[] evnt = new MyEventHandler[3];

        //    public event MyEventHandler SomeEvent
        //    {
        //        // Добавить событие в список.
        //        add
        //        {
        //            int i;
        //            for (i = 0; i < 3; i++)
        //                if (evnt[i] == null)
        //                {
        //                    evnt[i] = value;
        //                    break;
        //                }
        //            if (i == 3) Console.WriteLine("Список событий заполнен.");
        //        }
        //        // Удалить событие из списка.
        //        remove
        //        {
        //            int i;
        //            for (i = 0; i < 3; i++)
        //                if (evnt[i] == value)
        //                {
        //                    evnt[i] = null;
        //                    break;
        //                }
        //            if (i == 3) Console.WriteLine("Обработчик событий не найден.");
        //        }
        //    }
        //    // Этот метод вызывается для запуска событий.
        //    public void OnSomeEvent()
        //    {
        //        for (int i = 0; i < 3; i++)
        //            if (evnt[i] != null) evnt[i]();
        //    }
        //}
        //// Создать ряд классов, использующих делегат MyEventHandler.
        //class W
        //{
        //    public void Whandler()
        //    {
        //        Console.WriteLine("Событие получено объектом W");
        //    }
        //}
        //class X
        //{
        //    public void Xhandler()
        //    {
        //        Console.WriteLine("Событие получено объектом X");
        //    }
        //}
        //class Y
        //{
        //    public void Yhandler()
        //    {
        //        Console.WriteLine("Событие получено объектом Y");
        //    }
        //}
        //class Z
        //{
        //    public void Zhandler()
        //    {
        //        Console.WriteLine("Событие получено объектом Z");
        //    }
        //}
        //class EventDemo5
        //{
        //    static void Main()
        //    {
        //        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //        MyEvent evt = new MyEvent();
        //        W wOb = new W();
        //        X xOb = new X();
        //        Y yOb = new Y();
        //        Z zOb = new Z();
        //        // Добавить обработчики в цепочку событий.
        //        Console.WriteLine("Добавление событий. ");
        //        evt.SomeEvent += wOb.Whandler;
        //        evt.SomeEvent += xOb.Xhandler;
        //        evt.SomeEvent += yOb.Yhandler;
        //        // Сохранить нельзя - список заполнен.
        //        evt.SomeEvent += zOb.Zhandler;
        //        Console.WriteLine();
        //        // Запустить события.
        //        evt.OnSomeEvent();
        //        Console.WriteLine();
        //        // Удалить обработчик.
        //        Console.WriteLine("Удаление обработчика xOb.Xhandler.");
        //        evt.SomeEvent -= xOb.Xhandler;
        //        evt.OnSomeEvent();
        //        Console.WriteLine();
        //        // Попробовать удалить обработчик еще раз.
        //        Console.WriteLine("Попытка удалить обработчик " +
        //                    "xOb.Xhandler еще раз.");
        //        evt.SomeEvent -= xOb.Xhandler;
        //        evt.OnSomeEvent();
        //        Console.WriteLine();
        //        // А теперь добавить обработчик Zhandler.
        //        Console.WriteLine("Добавление обработчика zOb.Zhandler.");
        //        evt.SomeEvent += zOb.Zhandler;
        //        evt.OnSomeEvent();

        //        Console.ReadKey();


        //    }
        //}

        #endregion


        #region Применение анонимных методов и лямбдавыражений вместе с событиями
        //// Использовать лямбда-выражение в качестве обработчика событий.

        //// Объявить тип делегата для события.
        //delegate void MyEventHandler(int n);
        //// Объявить класс, содержащий событие.
        //class MyEvent
        //{
        //    public event MyEventHandler SomeEvent;
        //    // Этот метод вызывается для запуска события.
        //    public void OnSomeEvent(int n)
        //    {
        //        if (SomeEvent != null)
        //            SomeEvent(n);
        //    }
        //}
        //class LambdaEventDemo
        //{
        //    static void Main()
        //    {
        //        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //        MyEvent evt = new MyEvent();
        //        // Использовать лямбда-выражение в качестве обработчика событий.
        //        evt.SomeEvent += (n) =>
        //        Console.WriteLine("Событие получено. Значение равно " + n);
        //        // Запустить событие.
        //        evt.OnSomeEvent(1);
        //        evt.OnSomeEvent(2);
        //        Console.ReadKey();
        //    }
        //}

        #endregion

        #region  Пример формирования .NET-совместимого события.

        //// Объявить класс, производный от класса EventArgs.
        //class MyEventArgs : EventArgs
        //{
        //    public int EventNum;
        //}
        //// Объявить тип делегата для события.
        //delegate void MyEventHandler(object source, MyEventArgs arg);
        //// Объявить класс, содержащий событие.
        //class MyEvent
        //{
        //    static int count = 0;
        //    public event MyEventHandler SomeEvent;
        //    // Этот метод запускает событие SomeEvent.
        //    public void OnSomeEvent()
        //    {
        //        MyEventArgs arg = new MyEventArgs();
        //        if (SomeEvent != null)
        //        {
        //            arg.EventNum = count++;
        //            SomeEvent(this, arg);
        //        }
        //    }
        //}
        //class X
        //{
        //    public void Handler(object source, MyEventArgs arg)
        //    {
        //        Console.WriteLine("Событие " + arg.EventNum +
        //        " получено объектом класса X.");
        //        Console.WriteLine("Источник: " + source);
        //        Console.WriteLine();
        //    }
        //}
        //class Y
        //{
        //    public void Handler(object source, MyEventArgs arg)
        //    {
        //        Console.WriteLine("Событие " + arg.EventNum +
        //        " получено объектом класса Y.");
        //        Console.WriteLine("Источник: " + source);
        //        Console.WriteLine();
        //    }
        //}
        //class EventDemo6
        //{
        //    static void Main()
        //    {
        //        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //        X ob1 = new X();
        //        Y ob2 = new Y();
        //        MyEvent evt = new MyEvent();
        //        // Добавить обработчик Handler() в цепочку событий.
        //        evt.SomeEvent += ob1.Handler;
        //        evt.SomeEvent += ob2.Handler;
        //        // Запустить событие.
        //        evt.OnSomeEvent();
        //        evt.OnSomeEvent();
        //        Console.ReadKey();
        //    }
        //}

        #endregion

        #region Пример обработки событий, связанных с нажатием на клавиатуре.

        //Создать класс, производный от класса EventArgs и хранящий символ нажаатой клавиши.
        class KeyEventArgs : EventArgs {
            public char ch;
        }

        // Объявить класс события, связанного с нажатием клавиш на клавиатуре.
        class KeyEvent { 
            public event EventHandler<KeyEventArgs> KeyPress;

            // Метод вызывается при нажатии клавиши.
            public void OnKeyPress(char key) {
                KeyEventArgs k = new KeyEventArgs();
                if (KeyPress != null) { 
                    k.ch = key;
                    KeyPress(this, k);
                }            
            }
        }

        // Продемонстрировать обработку события типа KeyEvent.
        class KeyEventDemo { 
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                KeyEvent kevt = new KeyEvent();
                ConsoleKeyInfo key;
                int count = 0;

                // Использовать лямбда-выражение для отображения факта нажатия клавиши.
                kevt.KeyPress += (s, e) => Console.WriteLine($"  Получено сообщения о нажатии клавиши: {e.ch}");

                //Использовать лямбда-выражение для подсчета нажатых клавиш.
                kevt.KeyPress += (s,e) => {
                    count++;
                    Console.WriteLine(" --Прибавили единичку к count--");
                }; // count это внешняя переменная;

                Console.WriteLine( "Введите несколько символов. По завершении ввода введите \"точку\"." );

                do
                {
                    key=Console.ReadKey();
                    kevt.OnKeyPress(key.KeyChar);
                } while (key.KeyChar != '.');

                Console.WriteLine($"Было нажато {count} клавиш.");
                Console.ReadKey();
            }
        }

        #endregion


        //static void Main(string[] args)
        //{
        //}
    }
}
