using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class AdminUI
    {
        public static void AdminRun()
        {

            Console.Clear();
            Console.WriteLine("+----------------------------------------------------------------------------+");
            Console.WriteLine("|                                   ADMIN                                    |");
            Console.WriteLine("|1.Forrest                                                                   |");
            Console.WriteLine("|2.Parrot                                                                    |");
            Console.WriteLine("|3.Donut                                                                     |");
            Console.WriteLine("+----+----------------------+--------------+---------------------------------+");
            if (!byte.TryParse(Console.ReadLine(), out byte chooseOne))
            {
                Console.Clear();
                AdminRun();

            }
            switch (chooseOne)
            {
                case 1: ForrestPick(); break;
                case 2: ParrotPick();break;
                case 3: DonutPick(); break;
              
                default:
                    break;
            }

        }
        public static void ForrestPick()
        {

            while (true)
            {
                foreach (string item in ForrestFrame())
                {
                    SetRandomConsoleColor();
                    Console.Clear();
                    Console.Write(item);
                    Thread.Sleep(40);
                }
            }
        }
        public static void ParrotPick()
        {

            while (true)
            {
                foreach (string item in ParrotFrames())
                {
                    SetRandomConsoleColor();
                    Console.Clear();
                    Console.Write(item);
                    Thread.Sleep(40);
                }
            }
        }
        public static void DonutPick()
        {
            while (true)
            {
                foreach (string item in DonutFrames())
                {
                    SetRandomConsoleColor();
                    Console.Clear();
                    Console.Write(item);
                    Thread.Sleep(40);
                }
            }
        }
        static void SetRandomConsoleColor()
        {
            Random random = new Random();
            ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor randomColor = consoleColors[random.Next(consoleColors.Length)];
            Console.ForegroundColor = randomColor;
        }
        public static string[] DonutFrames()
        {
            return new string[]{
    @"
                                      ▓▓▓▓▓
                               ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
                            ▓▓▓▓▓▓▚▚▚$$$$$$$▚▚▚▓▓▓▓▓▓
                          ▓▓▓▓▚▚$$$$$$$$$$$$$$$$$▚▚▚▓▓▓
                        $▚▚▚▚$$$$$**!!!;;;!!!**$$$$$▚▚▚▚$
                       $▚▚▚$$$$**!!;::~~~~~~:;!!**$$$▚▚▚▚$
                      $$▚▚$$$$*!;;:~-,     ,-~:;;!*$$$$▚▚▚$
                      $$$$$$**!;:~-,          -~:;!**$$$$$$
                     *$$$$$$**!;:-,           ,-~;!!*$$$$$$*
                     *$$$$$$**!;:-             -::;!*$$$$$$*
                     !*$$$$$$***!;~           ,~:!!**$$$$$$!
                     !**$$$$$$$$**!;         :!!!$*$$$$$$$*!
                     ;!*$$$$$▚▚▚▚▚▚$$*     *$$$▚$▚▚$$$$$$*!;
                      ;!*$$$▚▚▚▚▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▚▚▚▚$$$$*!;
                      ~;!*$$$$▚▚▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▚▚$$$$**;~
                       ~;!**$$$▚▚▚▓▓▓▓▓▓▓▓▓▓▓▓▓▚▚▚$$$**!;~
                        ,:;!*$$$$$▚▚▓▓▓▓▓▓▓▓▓▚▚$$$$$*!;:
                          ,~;!**$$$$$$$$$$$$$$$$$**!;:-
                            ,~:;;!!**$$$$$$$**!!;;:-
                                --::::;;;;;:::~--
                                ",
                                @"
                                ▓▓▓▓▓▓▓▓▓▓▓▓▓
                            ▓▓▓▓▓▓▓▓▓▚▚▚▚▚▚▚▓▓▓▓▓
                          ▓▓▓▓▓▚▚▚$$$$▚*$$$$$$$▚▚▚▓▚
                        ▓▓▓▚▚▚▚$$$$$**********$*$$$▚▚▚
                      ▚▚▚▚▚▚▚$$$***!;;;;;;;;;!!!**$*$$$
                     $▚▚▚▚$$$$**!!;:~~~----~~:::;!!**$$$
                    $$▚▚$$$$**!!;:~-,       ,--::;!!**$$*
                    $$$$$$$**!;;:~-            -~:;!!****
                   *$$$$$$**!!;:~-             ,~:;!!****!
                   **$$$$***!;::~,             -~:;!!****!
                   !********!;;:~-           ~-:;;!!****!;
                   ;!*******!!!;:;:~        ;**$**$$****!;
                   :!!*********!***!!!    $▚▓▓▓▓▚▚▚$$$**;
                    :;!**********$$$$▚▚▓▓▓▓▓▓▓▓▓▓▚▚$$**!:
                     ;;!!!*****$$$$▚▚▓▓▓▓▓▓▓▓▓▓▓▚▚$$$*!:
                      ~;;!!!****$$$▚▚▚▓▓▓▓▓▓▓▓▓▚▚$$$*!~
                       ~:;;!!!*****$$$▚▚▚▚▚▚▚$$$$$*;:,
                         -~:;;!!***$$$$$$$$$$$**!;~,
                           ,-~:;;;!!!!*****!!;:~-
                                ,--~~~~~~~--,
",
@"
                                    ▓▓▓▓
                             ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
                          ▓▓▓▓▓▓▓▓▓▚▚▚▚$$$$$▚▚▚▚▚
                        ▓▓▓▓▓▓▚▚▚▚$$$*$$$$$*****$$$
                      ▚▓▓▓▓▚▚▚$$$$*****!!!!!!!!!****$
                     ▚▚▚▚▚▚▚▚$$*$**!!;;;:::::::;;!!***
                    ▚▚▚▚▚$$$$$**!!;;:~--,,,,,--~::;!!!!
                   $$$$$$$$***!!;;:~--         ,-~:;;!!
                  *$$$$$$$$**!!;:~~,            --~:;!!;
                  *$$$$$$***!!;::~-             -~~:;;!;
                  **$*$****!!;::~-,           ,-~:;;;;;;
                  !*******!!!;;:~-          ;~~:;;;!!!;:
                  !!*****!!!;;::~-,-      :$▚▚▚$$***!!;
                  ;!!!!!!!!!;;;:::~::;  $▓▓▓▓▓▓▓▚▚$**!:
                   ;;!!!!!!!!;;;;;;;!*$▚▓▓▓▓▓▓▓▓▚▚$*!:
                   ~;;;;;!!!;;;;;!!!**$▚▓▓▓▓▓▓▓▚▚**!:
                    -::;;;;;;;;!!!!!**$$▚▚▓▚▚▚$$$*!~
                     ,~:::;;;;;;!!!!****$$$*$*$*!:,
                       ,~~::::;;;;!!!!!!*!**!!;:,
                          ---~~~:::;;;;;;;::~,
                               ,,-------,
                               ",
                               @"
                                ▓▓▓▓▓▓▓▓▓▓▓▓
                            ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▚▚▚▚▚
                         ▓▓▓▓▓▓▓▓▓▓▚▚▚▚▚$$$**$$$$▚
                       ▚▓▓▓▓▓▓▓▚▚▚▚$$$****!!*;;*!**
                      ▚▓▓▓▓▓▚▚▚▚$$$$$***!!!;;;;;;;;!
                     ▚▚▚▚▚▚▚▚$▚$$$$**!;;;:~~~~~~~::;;
                    $▚▚▚▚▚▚$$$$$**!!;;:~~-,,   ,,-~:;
                   $$▚▚▚$$$$$***!!!;:~~-         ,-~::
                  *$$$$$$$$$**!!!;;:~-,           -~::
                  *$$$$$$$***!!;;::~-,           ,-~~~
                  **********!!;;::~-,         ,--~~::~
                  !*******!!!!;;:~-,      !!:::::::::
                  !!***!!!!!!;;::~-,    :▚▓▓▓▚▚*!!;;~
                  ;!!!!!!!!!;;::~~-,  $▚▓▓▓▓▓▓▓▚$*!:
                  :;;!!!!!;;;;::~~~--~;*▚▓▓▓▓▓▓▚**:
                   :;;;;;;;;;::::~~~~:;!$▚▚▚▚▚$*!:
                   -::::::::::::::~:::;!**$$***!:
                    -~~:::::::::::::::;;;!!!!!;-
                      --~~~~~~~~~~~::::;;;;::-
                        ,,-----~~~~~~~~~~~-
                             ,,,,,,,,,,
	",@"
                                 ▓▓▓▓▓▓▓▓▓▓▓▓▓
                              ▓▓▓▓▓▓▓▓▓▓▓▓▓▚▚▚▚▚▚
                            ▓▓▓▓▓▓▓▓▓▓▓▚▚▚▚$$$****
                          ▓▓▓▓▓▓▓▓▓▓▚▚▚$$$$*!!!!;;!
                        ▚▓▓▓▓▓▓▓▓▚▚▚▚$$$**!!!!;:~:;:
                       ▚▚▚▓▚▚▚▚▚▚▚▚$$$***!!;::~~--~~
                      $▚▚▚▚▚▚▚▚▚$$$$**!*;;:~~-,   ,-
                     $$▚▚▚▚▚▚$$$$$***!!;;:~-,      ,
                    *$$$▚$$$$$$$***!!!;;:~-        ,
                    *$$$$$$$$$****!!;;:~~,        ,,
                   ;**$$$$$$****!!!;;::-, ,    ,,--
                   !***********!!;;:::-, $$;::::~~-
                   !!*******!!!!;;;:~~-, ▓▓▓▚*!!:~
                   ;!!!!!!!!!!;;;:::~-, ▓▓▓▓▓▚*!:,
                   ;;!!!!!!!;;;;::~~--, $▚▓▓▚$!;-
                    ;;;;;;;;;;;::~~~-, ,;*$**!;-
                    ::;;;;;;::::~~~--,,,~;;!;;,
                     ~:::::::::~~~---,,-~:~;~
                      ~~~~~~~~~~-----,--~~~,
                       ,-----------,,,,,,
                           ,,,,,,,,,
	",@"
                                     ▓▓▓▓▓▓▓▓▓▓▓
                                  ▓▓▓▓▓▓▓▓▓▓▓▓▓▚▚▚
                                ▓▓▓▓▓▓▓▓▓▓▓▓▚▚▚▚$$*
                              ▚▓▓▓▓▓▓▓▓▓▓▓▓▚▚$$$*!!;
                             ▚▓▓▓▓▓▓▓▓▓▓▓▚▚▚$$**!!;:
                           *▚▚▓▓▓▓▓▓▓▚▚▚▚▚$$$**!!::-
                          $▚▚▚▚▚▚▚▚▚▚▚▚$▚$$***!;::,
                          $▚▚▚▚▚▚▚▚▚▚$▚$$$**!!;:~,
                         $$$▚▚▚▚▚▚$$$$$$**!!!;:~,
                        *$$$$▚$$$$$$$$***!!;;:~,
                       !*$$$$$$$$$$$***!!;;;:~-
                       !*$*$$$$$$*****!!!;::~- ,
                       !************!!!;;::~- ~,
                      ;!**********!!!;;;:~~- ;~
                      ;!!!!!!!!!!!!!;;:::~-,;:
                      :;!!!!!!!!!;;;;::~~-,:~
                       ;;;;;;;;;;;::::~--, -
                       ::;;;;;;:::::~~--, -
                       ~~::::::::~~~~-,,
                        -~~~~~~~~~--,,,
                          --------,,,
	",@"
                                           ▓▓▓▓▓▓
                                       ▚▓▓▓▓▓▓▓▓▓▓▓▚
                                     $▓▓▓▓▓▓▓▓▓▓▓▓▓▚$
                                    ▚▚▓▓▓▓▓▓▓▓▓▓▓▓▚▚$*
                                   $▚▓▓▓▓▓▓▓▓▓▓▓▚▚▚$$*;
                                 !$▚▚▓▓▓▓▓▓▓▓▓▚▚▚▚▚$*!:
                                !$▚▚▚▓▓▓▓▓▓▓▚▚▚▚▚$$$*!:
                               !$$▚▚▚▚▚▚▚▚▚▚▚▚▚$$$**!;
                               *$▚▚▚▚▚▚▚▚▚▚▚▚▚▚$***!;:
                              *$$$▚▚▚▚▚▚▚▚$$$$$$**!;:~
                             **$$$$▚▚$$$$$$$$***!!;;~
                            ;**$$$$$$$$$$$$****!!;:~,
                            !***$$$$$$$$$*****!;;;:-
                           ;!****$$$********!!!;::-
                           ;!!***********!!!!;;::-
                           ;!!!**!****!!!!;;;::~-
                          :;!!!!!!!!!!!!;;;:::~-
                          :;;;;!!!!;!;;;;:::~-,
                          ~::;;;;;;;;;:::~~~-,
                           ~:::::::::::~~--,
                            -~~~~~~~~~~--,
	",@"
                                           ▓▓▓▓▓▓▓▓▓▓
                                         $▚▓▓▓▓▓▓▓▓▓▓▓▓
                                        *$▚▓▓▓▓▓▓▓▓▓▓▓▓▚$
                                      ;;*▚▚▓▓▓▓▓▓▓▓▓▓▓▓▚▚*
                                     ;-!$▚▚▓▓▓▓▓▓▓▓▓▓▓▚▚$$
                                     ~!*$▚▚▓▓▓▓▓▓▓▓▓▓▚▚▚$*
                                    :~*$$▚▚▚▓▓▓▓▓▓▓▓▚▚▚$$*;
                                   !:*$$▚▚▚▚▚▚▓▓▚▚▚▚▚▚$$**;
                                  **!*$$▚▚▚▚▚▚▚▚▚▚▚▚▚$$$*!:
                                 *▚!**$$$▚▚▚▚▚▚▚▚▚▚▚$$**!;
                                 ▚:**$$$$▚▚▚▚▚▚$▚$$$$$*!;;
                                ▚▓!**$$$$$$$▚$$$$$*****!;-
                               $▚!!**$$$$$$$$$$$*$**!!!;~
                              !$;!****$*$$$$$$$****!!;;~
                              !;!!***************!!;;;~
                             ;;;!!!**********!!!!!;;:~,
                             :;;;!!!!!!!!!!!!!!;;;::~
                             ::;;;!!!!!!!!!!;;;:::~-
                             ~::;;;;;;;;;;;;:::~--,
                              ~~::::::::::::~~--,
	",@"
                                               ▓▓▓
                                         ▚▚▚▚▓▓▓▓▓▓▓▓▓▓
                                       $***$▚▚▚▓▓▓▓▓▓▓▓▓▓▓
                                     *!::;!**$▚▓▓▓▓▓▓▓▓▓▓▓▓
                                    !;;~~~;!*$▚▚▓▓▓▓▓▓▓▓▓▓▓▚
                                  *!;:-,,-:!*$▚▚▚▓▓▓▓▓▓▓▓▓▓▚$
                                 *!;:-   ,:!*$▚▚▚▓▓▓▓▓▓▓▓▓▚▚$
                                **!;~-   -;*$$▚▚▚▚▓▓▓▓▓▓▚▚▚$$!
                               !$$*!:-   ;!*$$▚▚▚▚▚▚▚▓▚▚▚▚▚$*!
                               $▚▓▚*!;~-~!**$$▚▚▚▚▚▚▚▚▚▚▚▚$$*!
                              *▓▓▓▓▓▓$!~;**$$$▚▚▚▚▚▚▚▚▚$$$$*!;
                              ▚▓▓▓▓▓▓▓*!!*$$$$$▚▚▚▚▚▚▚$$$$**!:
                             !▚▓▓▓▓▓▓;!!**$$$$$$▚▚$$$$$$**!!;
                             *▚▓▓▚$!!!****$$$$$$$$$$$$$***!;~
                             *$$$**!******$$$$$$$$$$****!!;:
                             !***************$********!!;;~
                             :!!!!!!!**************!!!;;:~
                             ~;;!!!!!!!*!*!!*!!!!!!;;;::-
                              ~:;;!!!!!!!!!!!;!;;;;;:~-
                               ~~::;;;;;;;;;;;;:::~~-
	",@"
                                         ▓▓▓▓▓▓▓▓▓▓▓▓▓
                                     ▚▚$$$$▚▚▚▚▓▓▓▓▓▓▓▓▓▓
                                   $$*!!!!!***▚▚▚▓▓▓▓▓▓▓▓▓▓
                                 $*!!!!:;;:;;!*$$▚▓▓▓▓▓▓▓▓▓▓$
                                $*!!;:~~-~~::!!*$$▚▓▓▓▓▓▓▓▓▓▚$
                              !$**!;~-,    -~;!*$$▚▚▓▓▓▓▓▓▓▓▚▚
                              $$**;:~,      -;!**$▚▚▓▓▓▓▓▓▓▓▚▚*
                             $▚▚**;:~,      -;!*$$▚▚▚▚▓▓▓▓▚▚▚▚*
                            *▚▚▓▚▚$!:-      :;**$$$▚▚▚▚▚▚▚▚▚$$*
                            $▚▓▓▓▓▓▚*:,    ~;!*$$$▚▚▚▚▚▚▚▚▚▚$$*
                           :▚▓▓▓▓▓▓▓▚*,   :!!*$$$$▚▚▚▚▚▚▚▚▚$$**
                           ;▚▓▓▓▓▓▓▓▓▚*  ;!**$$$$$$$▚$$$$$$$*!!
                           ;$▓▓▓▓▓▓▓▚$******$$$$$$$$$$$$$***!!:
                           :*▚▚▓▓▓▓▚▚$$$$$$$$$$$$$$$$$$$$**!!:
                            ;*$▚▚▚▚▚▚$$$$$$$$$$$$$$$$*****!;:
                            ~!!$$$$$$$$$$*$$**$*********!;;:
                             :;;!**$***************!!!!;;:~
                              ~;!;!!!!******!*!!!!!!;;::~
                                ~:;;;;!!!!;!;;;;;;:::~-
                                `,`
                                      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓
                                   ▓▓▚▚▚▚▚▚▚▚▓▓▓▓▓▓▓▓▓▓
                                ▚▚▚$$**$*!**$$$▚▚▚▓▓▓▓▓▓▓▓
                              ▚▚$$****!!!!!!!!*$$▚▚▚▓▓▓▓▓▓▓$
                             $$$$**!;::~~~~:;!!**$$▚▚▓▓▓▓▓▓▓▚
                            $$$$*!;:~-,   ,-~:;;**$▚▚▚▚▓▓▓▓▓▚$
                           $$$$*!;:~-       ,-~;!**$▚▚▚▚▓▓▓▚▚▚
                          *$▚▚$**;:-,        ,~;!**$▚▚▚▚▚▚▚▚▚$*
                          $▚▚▚▚▚$*;~,         ~;!*$$$▚▚▚▚▚▚▚▚$*
                         !$▚▓▓▓▓▚▚$!-        -;!**$$$▚▚▚▚▚▚▚$$*
                         ;$▚▓▓▓▓▓▓▚$*        ;!**$$$$▚▚▚▚▚$$$**
                         ;$▚▓▓▓▓▓▓▓▓▓$     !****$$$$▚▚▚$$$$$$*!
                         :*$▚▓▓▓▓▓▓▓▓▓▚▚$$$$$$$$$$$$$▚$$$$$**!:
                          ;*$▚▓▓▓▓▓▓▓▓▓▓▚▚▚▚▚▚$$$$$$$$$$$***!;
                          ~!*$▚▓▓▓▓▓▓▓▓▓▚▚▚▚▚▚$$$$$$$$****!!:
                           :!!*$▚▚▚▚▚▚▚▚▚▚▚▚$$$$$$$$****!!;:
                            ~;!!*$$$$$$$$$$$$*$$*****!!!;:~
                              :;!*****$**$$******!!!;;::~
                                -:;;;!!!!!!!!!!;;;;:~-,
",@"
                                   ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
                                ▓▓▓▚▚▚▚▚▚▚▚▚▚▓▓▓▓▓▓▓▓▓
                             ▓▓▚▚▚$$$$$$**$$$$$▚▚▓▓▓▓▓▓▓
                           ▚▚▚▚$$$$***!!!!!!**$$$$▚▚▚▓▓▓▓▓
                          ▚▚▚$$$*!!!;::::::::;!**$$$▚▚▚▓▓▓▚
                         $▚▚$$**!!;~--,,  ,,-~:;!**$$▚▚▚▚▚▚▚
                        *$▚$$$*!;:~-,        ,~:;!*$$$▚▚▚▚▚▚$
                        $$▚$$$*!;~-           ,~:!!*$$▚▚▚▚▚▚$*
                       *$$▚▚▚$$*!:-           ,~;!**$$$▚▚▚▚$$*
                       !$$▚▚▚▚▚$**;~          ~:!!*$$$$▚▚▚$$$!
                       !*$▚▚▚▚▚▚▚▚$!         ~;!**$$$$$$$$$$$!
                       ;*$▚▚▚▓▓▓▓▓▓▓▚$      **$$$$$$▚▚$$$$$**;
                        !*$▚▚▓▓▓▓▓▓▓▓▓▓▓▓▚▚▚▚▚▚▚▚▚▚▚▚$$$$$*!!
                        ;!$$▚▚▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▚▚▚▚▚▚$$$$$**!:
                         :!*$$▚▚▓▓▓▓▓▓▓▓▓▓▓▓▓▓▚▚▚▚$$$$$**!;:
                          :;*$$$▚▚▚▓▓▓▓▓▓▓▚▚▚▚▚$$$$$$**!!;~
                           ,;!*$$$$$$$▚▚▚▚$$$$$$$$***!;:~
                             ,:;!!!*$$$$$$$$*****!!;;:~
                                -~::;!!!!!!!!!;;;:~-,
    "
};

        }

        public static string[] ParrotFrames()
        {
            return new string[]{
    @"                   .cccc;;cc;';c.
                      .,:dkdc:;;:c:,:d:.
                     .loc'.,cc::::::,..,:.
                   .cl;....;dkdccc::,...c;
                  .c:,';:'..ckc',;::;....;c.
                .c:'.,dkkoc:ok:;llllc,,c,';:.
               .;c,';okkkkkkkk:,lllll,:kd;.;:,.
               co..:kkkkkkkkkk:;llllc':kkc..oNc
             .cl;.,okkkkkkkkkkc,:cll;,okkc'.cO;
             ;k:..ckkkkkkkkkkkl..,;,.;xkko:',l'
            .,...';dkkkkkkkkkkd;.....ckkkl'.cO;
         .,,:,.;oo:ckkkkkkkkkkkdoc;;cdkkkc..cd,
      .cclo;,ccdkkl;llccdkkkkkkkkkkkkkkkd,.c;
     .lol:;;okkkkkxooc::loodkkkkkkkkkkkko'.oc
   .c:'..lkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkd,.oc
  .lo;,ccdkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkd,.c;
,dx:..;lllllllllllllllllllllllllllllllloc'...
cNO;........................................",

    @"             .ckx;'........':c.
             .,:c:c:::oxxocoo::::,',.
            .odc'..:lkkoolllllo;..;d,
            ;c..:o:..;:..',;'.......;.
           ,c..:0Xx::o:.,cllc:,'::,.,c.
           ;c;lkXXXXXXl.;lllll;lXXOo;':c.
         ,dc.oXXXXXXXXl.,lllll;lXXXXx,c0:
         ;Oc.oXXXXXXXXo.':ll:;'oXXXXO;,l'
         'l;;OXXXXXXXXd'.'::'..dXXXXO;,l'
         'l;:0XXXXXXXX0x:...,:o0XXXXk,:x,
         'l;;kXXXXXXKXXXkol;oXXXXXXXO;oNc
        ,c'..ckk0XXXXXXXXXX00XXXXXXX0:;o:.
      .':;..:dd::ooooOXXXXXXXXXXXXXXXo..c;
    .',',:co0XX0kkkxx0XXXXXXXXXXXXXXX0c..;l.
  .:;'..oXXXXXXXXXXXXXXXXXXXXXXXXXXXXXko;';:.
.cdc..:oOXXXXXXXXKXXXXXXXXXXXXXXXXXXXXXXo..oc
:0o...:dxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxo,.:,
cNo........................................;'",

    @"      .cc;.  ...  .;c.
         .,,cc:cc:lxxxl:ccc:;,.
        .lo;...lKKklllookl..cO;
      .cl;.,;'.okl;...'.;,..';:.
     .:o;;dkx,.ll..,cc::,..,'.;:,.
     co..lKKKkokl.':lllo;''ol..;dl.
   .,c;.,xKKKKKKo.':llll;.'oOxo,.cl,.
   cNo..lKKKKKKKo'';llll;;okKKKl..oNc
   cNo..lKKKKKKKko;':c:,'lKKKKKo'.oNc
   cNo..lKKKKKKKKKl.....'dKKKKKxc,l0:
   .c:'.lKKKKKKKKKk;....oKKKKKKo'.oNc
     ,:.,oxOKKKKKKKOxxxxOKKKKKKxc,;ol:.
     ;c..'':oookKKKKKKKKKKKKKKKKKk:.'clc.
   ,dl'.,oxo;'';oxOKKKKKKKKKKKKKKKOxxl::;,,.
  .dOc..lKKKkoooookKKKKKKKKKKKKKKKKKKKxl,;ol.
  cx,';okKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKl..;lc.
  co..:dddddddddddddddddddddddddddddddddl:;''::.
  co...........................................",

    @"     .ccccccc.
      .,,,; cooolccol; ;,,.
     .dOx; ..; lllll; ..; xOd.
   .cdo,',loOXXXXXkll;'; odc.
  ,oo:; c,':oko:cccccc,...ckl.
  ; c.; kXo..::..; c::'.......oc
,dc..oXX0kk0o.':lll;..cxxc.,ld,
kNo.'oXXXXXXo'':lll;..oXXOd;cOd.
KOc; oOXXXXXXo.':lol,..dXXXXl'; xc
Ol,:k0XXXXXX0c.,clc'.:0XXXXx,.oc
KOc; dOXXXXXXXl..';'..lXXXXXd..oc
dNo..oXXXXXXXOx:..'lxOXXXXXk,.:; ..
cNo..lXXXXXXXXXOolkXXXXXXXXXkl; ..;:.;.
.,; '.,dkkkkk0XXXXXXXXXXXXXXXXXOxxl;,;,;l:.
  ; c.;:''''':doOXXXXXXXXXXXXXXXXXXOdo;'; clc.
  ; c.lOdood:'''oXXXXXXXXXXXXXXXXXXXXXk,..;ol.
  ';.:xxxxxocccoxxxxxxxxxxxxxxxxxxxxxxl::'.';;.
  ';........................................;l'",


    @"
        .;:;;,.,;;::,.
     .;':;........'co:.
   .clc;'':cllllc::,.':c.
  .lo;;o:coxdlooollc;',::,,.
.c:'.,cl,.'lc',,;;'......cO;
do;';oxoc::l;;llllc'.';;'.';.
c..ckkkkkkkd,;llllc'.:kkd;.':c.
'.,okkkkkkkkc;llllc,.:kkkdl,cO;
..;xkkkkkkkkc,ccll:,;okkkkk:,cl,
..,dkkkkkkkkc..,;,'ckkkkkkkc;ll.
..'okkkkkkkko,....'okkkkkkkc,:c.
c..ckkkkkkkkkdl;,:okkkkkkkkd,.',';.
d..':lxkkkkkkkkxxkkkkkkkkkkkdoc;,;'..'.,.
o...'';llllldkkkkkkkkkkkkkkkkkkdll;..'cdo.
o..,l;'''''';dkkkkkkkkkkkkkkkkkkkkdlc,..;lc.
o..;lc;;;;;;,,;clllllllllllllllllllllc'..,:c.
o..........................................;'",

    @"
           .,,,,,,,,,.
         .ckKxodooxOOdcc.
      .cclooc'....';;cool.
     .loc;;;;clllllc;;;;;:;,.
   .c:'.,okd;;cdo:::::cl,..oc
  .:o;';okkx;';;,';::;'....,;,.
  co..ckkkkkddk:,cclll;.,c:,:o:.
  co..ckkkkkkkk:,cllll;.:kkd,.':c.
.,:;.,okkkkkkkk:,cclll;.:kkkdl;;o:.
cNo..ckkkkkkkkko,.;llc,.ckkkkkc..oc
,dd;.:kkkkkkkkkx;..;:,.'lkkkkko,.:,
  ;c.ckkkkkkkkkkc.....;ldkkkkkk:.,'
,dc..'okkkkkkkkkxoc;;cxkkkkkkkkc..,;,.
kNo..':lllllldkkkkkkkkkkkkkkkkkdcc,.;l.
KOc,l;''''''';lldkkkkkkkkkkkkkkkkkc..;lc.
xx:':;;;;,.,,...,;;cllllllllllllllc;'.;oo,
cNo.....................................oc",

    @"

                   .ccccccc.
               .ccckNKOOOOkdcc.
            .;;cc:ccccccc:,::::,,.
         .c;:;.,cccllxOOOxlllc,;ol.
        .lkc,coxo:;oOOxooooooo;..:,
      .cdc.,dOOOc..cOd,.',,;'....':c.
      cNx'.lOOOOxlldOl..;lll;.....cO;
     ,do;,:dOOOOOOOOOl'':lll;..:d:.'c,
     co..lOOOOOOOOOOOl'':lll;.'lOd,.cd.
     co.,dOOOOOOOOOOOo,.;llc,.,dOOc..dc
     co..lOOOOOOOOOOOOc.';:,..cOOOl..oc
   .,:;.'::lxOOOOOOOOOo:'...,:oOOOc..dc
   ;Oc..cl'':llxOOOOOOOOdcclxOOOOx,.cd.
  .:;';lxl''''':lldOOOOOOOOOOOOOOc..oc
,dl,.'cooc:::,....,::coooooooooooc'.c:
cNo.................................oc",

    @"


                        .cccccccc.
                  .,,,;;cc:cccccc:;;,.
                .cdxo;..,::cccc::,..;l.
               ,oo:,,:c:cdxxdllll:;,';:,.
             .cl;.,oxxc'.,cc,.',;;'...oNc
             ;Oc..cxxxc'.,c;..;lll;...cO;
           .;;',:ldxxxdoldxc..;lll:'...'c,
           ;c..cxxxxkxxkxxxc'.;lll:'','.cdc.
         .c;.;odxxxxxxxxxxxd;.,cll;.,l:.'dNc
        .:,''ccoxkxxkxxxxxxx:..,:;'.:xc..oNc
      .lc,.'lc':dxxxkxxxxxxxdl,...',lx:..dNc
     .:,',coxoc;;ccccoxxxxxxxxo:::oxxo,.cdc.
  .;':;.'oxxxxxc''''';cccoxxxxxxxxxkxc..oc
,do:'..,:llllll:;;;;;;,..,;:lllllllll;..oc
cNo.....................................oc",

    @"

                              .ccccc.
                         .cc;'coooxkl;.
                     .:c:::c:,;,,,;c;;,.'.
                   .clc,',:,..:xxocc;...c;
                  .c:,';:ox:..:c,,,,,,...cd,
                .c:'.,oxxxxl::l:.;loll;..;ol.
                ;Oc..:xxxxxxxxx:.,llll,....oc
             .,;,',:loxxxxxxxxx:.,llll;.,;.'ld,
            .lo;..:xxxxxxxxxxxx:.'cllc,.:l:'cO;
           .:;...'cxxxxxxxxxxxxol;,::,..cdl;;l'
         .cl;':;'';oxxxxxxxxxxxxx:....,cooc,cO;
     .,,,::;,lxoc:,,:lxxxxxxxxxxxo:,,;lxxl;'oNc
   .cdxo;':lxxxxxxc'';cccccoxxxxxxxxxxxxo,.;lc.
  .loc'.'lxxxxxxxxocc;''''';ccoxxxxxxxxx:..oc
occ'..',:cccccccccccc:;;;;;;;;:ccccccccc,.'c,
Ol;......................................;l'",

    @"
                              ,ddoodd,
                         .cc' ,ooccoo,'cc.
                      .ccldo;....,,...;oxdc.
                   .,,:cc;.''..;lol;;,'..lkl.
                  .dkc';:ccl;..;dl,.''.....oc
                .,lc',cdddddlccld;.,;c::'..,cc:.
                cNo..:ddddddddddd;':clll;,c,';xc
               .lo;,clddddddddddd;':clll;:kc..;'
             .,:;..:ddddddddddddd:';clll;;ll,..
             ;Oc..';:ldddddddddddl,.,c:;';dd;..
           .''',:lc,'cdddddddddddo:,'...'cdd;..
         .cdc';lddd:';lddddddddddddd;.';lddl,..
      .,;::;,cdddddol;;lllllodddddddlcodddd:.'l,
     .dOc..,lddddddddlccc;'';cclddddddddddd;,ll.
   .coc,;::ldddddddddddddl:ccc:ldddddddddlc,ck;
,dl::,..,cccccccccccccccccccccccccccccccc:;':xx,
cNd.........................................;lOc",
};

    }
    public static string[] ForrestFrame()
        {
           return   new string[]{
    @"
                      ,dlc:;.           
                     .,;lkOx,           
                     .,,cxkd'           
                     ,c;cccl'           
                   ..',:ol;.            
                  .....,lko.            
                '::'..,,;dxl.           
             .';:;,'..,:;:dxl:,.....    
             ,c,:c:,..,::;:odddoooddl.  
              .;:oc,'':llclddd:',,cko.  
               ';::,,:dkdl:,,,.   .,.   
               ':',;:oOOdo:..           
               :d,,:clddk00Odc,         
               ,l,;:ccc:coxk00Od:,      
              .;;;:cccc;.,::cldxxd,     
             .:;,::ccc,   ,:;;;cdd'     
        ..,,,cc;;::;,.       .,lxd'     
 ..,c:,;ccclooc::c,          .,:od,     
:dxoc:;;;;;;:cc;'.           ';,co'     
ldoc:;''',.....              .',cd,     
lll;.                         .;cxd,..  
cl;.                          .:;cddddl.
::.                            .,,,,,,' 
                                        
                                        
                                        

",
    @"
                      .'cxc.            
                      .:cdOo'           
                     .,';dOxo'          
                      ';:ccll.          
                   .lc;:oo;'.           
                  ':;,';dkl.            
                  ',..',dko;            
                ';;'..',lkoo'           
               .:::,..,,:oxxo:,....     
               .:co:.':cc:cloddddodc.   
                ,:;;,:dkdl:'',:llooc.   
                ':,;:oOOoo'    ....     
                .;';:lxkxko,            
                .;',:codk00ko.          
                ':,,::lc:lk00x;.        
   .::cc,...   .::,;::cl:;:cdkko.       
  ,cddxollll:;lxd:,;:clc'',;:cdd,       
.:oc:,;lc:;;:ccodl::cco'   .:cxd'       
,d:.. ......'',;;::ccl;    .;:dd'       
 .             ..;,,,;.    ':;co;       
                           .:::od,      
                            'c:ox;      
                            .::lxdc,.   
                            .cccloddx,  
                              ........  
                                        

",
    @"
                       .''''.           
                      .:clxx:           
                      .;,lOOd'          
                      .;,cllo'          
                    .';:ll:::.          
                   .c;':xxo,            
                  .''.,dOxo;            
                  ,,..;xxoll'           
                 ;:'..:xxlcl'           
                .:;'.';cddd:.           
                 .;,,;llcldxo:,.        
                .;;;:oOOo;:lddxxl.      
                .;',:lOOd;.':looo'      
                .,'',;okkx:  ',,'.      
         ....    .,'.,:oxkkc.           
       ,ldxkxl;'..,;'',cokOk:           
     .clccccc::cllool:;:lldkx;          
    .;,'.....,:c;::llllclccodx;         
              ...'.,;;::cccol:.         
                    ..';::odo'          
                       'c;clo'          
                       'c;:lc.          
                       'l:cd,           
                       'lcoxo,          
                       'lccoddl:.       
                       ,ollloooc.       

",
    @"
                        .''.            
                      .;,lxo,           
                      .,,lOOx'          
                      .;,:ooo'          
                   .'';:cl:,:.          
                   'l:;oxol'            
                  .,,:dkdoo;            
                  'cldxlclll'           
                .ccokko:ccc:.           
                .;::coxoccl'            
                 .;,';lxolx;            
                .;;;:codddoc:,          
                .;',:lkkddoclo:.        
                .''.',:oddol:;:.        
             ..  .,'..';coxx:           
            :dxo:,,;,,,,,:oxxl.         
          .lodddlcc:::ccclloxxo.        
         .colll:'.,:;;;;:cccldd,        
          ;oc'.   .loc:;::ccc:,.        
           .      ;c:cllll;..           
                 'l:;cll,               
                .cc::cc,                
                'l::llc.                
               .cllodd,                 
               'lccoddl:;.              
               'l:;:clodd,              

",
    @"
                      ';''',.           
                      'ccdkk:           
                     .,';dOko.          
                     .;;:cclc.          
                    .;lcolc;.           
                  ':cldxdod,            
                ':oxkxoccoo;            
              .:cdxlc:;:clld,           
               ';dk:'',:ccc;.           
               .,:do;,;clcll,..         
                .,cooloxdccclcc;;:.     
                .,,cdxOOdl:,,;::cl'     
                .,';cokkOOko::'...      
                ':'',,;:coxkOko,.       
                'c,;ccc:;,;:ldkkxo.     
                'c,:lodolc::codddd,     
                'c,:clllc:::ccc:::.     
               .llccc::;;;::,'...       
              ':lloolccl:...            
            .:cclloooo;.                
           .:c;:ccodd:                  
          'cc::c:;;;:.                  
        'colllc'                        
        ;lclod,                         
         .:odx:.                        
          'ooddx,                       

",
    @"
                       ;lo:.            
                      .;lkOo.           
                     .,':xkxc.          
                     ,l;cc:ld,          
                  ...;lool,.            
                .:ldoddood;             
             .,:oddlc:;;ldo'            
             .;okd:,.';:ccc'            
             ,c:xkl,.',:ccc:;'..,;:,    
             .;:okc''':llc;,;;:;,;:o,   
               ,ldl,,:dkdc;'....,,:;.   
               .cdo::lkOxdl,.           
               ;dcc;;:lodxkOkdc,.       
               :o,,,,,,,;;:loxkkko:.    
               ';;cllc:,.';,,;;cdxd,    
              ':;:clcc,   ..::;cdo:.    
            .,:;;:c:,'     'l::loo'     
         ';cooc;::;.      .cc;:co:.     
       'clccllc:;.        ;l:;:l;       
    .,clc:;:c;;'         :ol::ll.       
  .coolccc:,'           'oollod:        
  .:clloc'              .coooxxxl,.     
   'lod:                  .,cddddd,     
   .cod,                     .....      
     ..                                 
                                        

",
    @"
                      ;xc::.            
                     .,;lkOo.           
                     .,'cxkd,           
                     'c;cc:l'           
                ...',:ldoc;,.           
               'cdddoodood:             
             .:oddoc:;;:ldo'            
             .:dko:'.';:ccc'     .'.    
             .:lkxc,.',:ccc;,,,',col.   
              ':dxl,.':llc;,;;::;;::.   
               'odc,;:dkdl,........     
               .odc;cokOxdl,.           
               .::,,;;coxkOOko,.        
               .:,;,,,,,;:codkkko:,     
              .:;:clccc;,:;;;:coxxx,    
             'l:;:ccc:'. .,:':c;lxd'    
      ..,;,;;cc;:cc;'.       ;l;lxd'    
 ,clc;cl::clol:;:l;          .;,:oo'    
.loooc::;;;c;...''            .,;cl'    
'llll:;;.....                 .'':l'    
:lo;.                          .,;o:.   
:ol.                           .;;oxdc;,
 ..                             ':coooc;
                                 .....  
                                        
                                        

",
    @"
                      .':xc.            
                     .:ccxOd'           
                     ,l';dOxo'          
                      ';:ccll.          
                  .,,:clol,'.           
                 'lddddxdoc.            
               'codxkdc:cdo;.           
              'loxd:,,;:cclc.           
              'ccxx;.',:ccc;.           
              .;:ld:'';llccol;;,;:,.    
               .;col:cdkdc:ccc:;:cl.    
                'ccdxxOOdoc....,,.      
                .;:ododkOOx:            
                .:,,,,,:oxOOo,          
      ..        'c;:cc:,,;cdkko'        
    'ldxl,......;:;cooooc;;;cdkd:.      
   ;olodolcccloxdc;cllo:..',;:oxd'      
 .clloc,,:c:;;:loc:clld;   ,l;lxd,      
 .;,''.  .....'.',;:cl:.   'c;cdd,      
                 .....     'l;:lo'      
                           .;:;:l'      
                            .:;:l:.     
                             .::oxl'.   
                             'c:oxxool. 
                             .,,,;;;;,  
                                        

",
    @"
                       .''''.           
                      .cclxx:           
                      .;,lOOd'          
                      .;,cllo'          
                    .';cll:::.          
                   ,c:cdxol;            
                  ;lcokxooo;            
                 ;loxxocclll'           
                'ccxOd::cccl'           
                .::ldxocccl'            
                 ':,,cdxold:..          
                .;,;:coxdllllol.        
                .;';:lodxxoc:cll.       
                .,'.',:llod;';'.        
         ,::,.   .:'..';cdxo.           
      .,looxxl;;;';:,'',;cdxl.          
     .:ollc:cc::cloooc;;;;cdd:.         
     .:,,.. .';;:,;clc:cc:;cdd,         
               ..';;c:;;cc:loo'         
                    ..':c::oo;          
                       'c;:ll'          
                       'c;;co'          
                       .c:;co,          
                       'l::od:          
                       'lcldxdc:.       
                       'lcloddod,       

",
    @"
                        .''.            
                      .;,lxo,           
                      .,,lOOx'          
                      .;,:ooo'          
                   ..,;:cl:,:.          
                   'l:,cxdl'            
                  .,'';xkdo;            
                  .,''lkdlll'           
                  ''.,okocc:.           
                 .;'.':dxol'            
                 .:,',:cldxo,.          
                .;;;:lkklcodxoc.        
                .;';:oOOdooloddl.       
                .''',:okkxxl;coc.       
             ... .,'.':oxOOo,.'.        
            :dxxl::;'',coxOOx:          
          .looodolc;,'':lloxkx:.        
         .coooc,,,',c:,;cc:clol.        
          ';;'     .:c;;cl:,'.          
                  ':cccll:.             
                 'l:;:cll'              
                 ;c;;:co;               
                'l;;;:l:                
               .cc;:ll:.                
               'lcldxdol;               
               'lcldxxdool.             

",
    @"
                      ';''',.           
                      'ccdkx:           
                     .,';dOko'          
                      .,;cclc.          
                    ..':llc;.           
                   .,'';dxo.            
                 .,,..';xko;            
                .c;'..';dxlo,           
               .';;'..',lxxxo,          
               ,c:l:'';::codxxo::,.     
               .cc;;,;oxoc;;lloddxdc.   
                ,c,;:oOOol;...';:lll'   
                .;';:lkkkkxl:.   ..     
                .;',:cddxO00Od:,        
                ':',;:ll::coxOOko,      
                .;',::clc::clooddc.     
                ':';:ccc:;;::;::,.      
               .lc,;:cc:::l:. ..        
              'clc:::clc'.'.            
            .ccccllll:'                 
           .cc;:ccldd,                  
          'cc;;::'...                   
        ,loc;:lc.                       
       'ooollo;                         
        ,loxxd:..                       
         ;oddddx,                       

",
    @"
                      .:doc,.           
                     .;:lkOk,           
                     .;,cxkxc.          
                     ,c;cc:ld,          
                   .'',:ol,.            
                  .''..,okl.            
                 .,'..,,:xx;            
              .,,,,'..,;;cxx:''..       
              .;:c:'..,::;cdxxdddl::'   
              '::oc,'':ll:ll:;c:cool;.  
              .;:::,,:dkdl:'. .. ...    
               .'',;:oOOdo;..           
                .,,:clxxkOOOdc,         
               .:,,:cclccoxk00Od:'      
               ',,;:ccc;;c;;:coxxd'     
              ':,;:ccc:..'':::loc:.     
            .,:;;::cc,    ,l:coo:.      
         ,;cool:::;..    .cc;:lc.       
       'clcccll::;.      ;oc:lo'        
   .,;cc::::cl:..       :oolod:         
 .ldol:::c:,'..        ,olloxx:         
 'oddll:'.              ..:odxx:        
 .codoc.                   ,;;::.       
  .cooo'                                
    ';:.                                
                                        

"};


        }
    }
}
