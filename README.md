# ProcessOn
This is the course project of 《系统软件课程设计》  
# Description  
课题二：进程调度模拟程序
设计要求：编写一个进程调度程序，允许多个进程共享进程调度程序。    

进程调度算法：  
（1）最高优先数优先的调度算法（即把处理机分配给优先数最高的进程）  
（2）时间片轮转法  
（3）先来先服务算法

每个进程有一个进程控制块（ PCB）表示。  
进程控制块可以包含如下信息：  
进程名、优先数、到达时间、需要运行时间、已用CPU时间、进程状态等等。   

进程的优先数、到达时间、时间片以及需要的运行时间由随机数产生。  
1、设计内容  
1）设计进程控制块PCB表结构，分别适用于优先权调度算法、时间片轮转调度算法和先来先服务算法。  
2）PCB结构包括以下信息：进程名、进程优先数（或轮转时间片），进程所占用的CPU时间，进程的状态，当前队列指针等。根据调度算法的不同，PCB结构的内容可以作适当的增删。  
3）建立进程就绪队列。对两种不同算法编制入链子程序。  
4）编制三种进程调度算法：A、优先数调度；B、循环轮转调度；C、先来先服务   

 

