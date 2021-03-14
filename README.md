# PSDS
Urban air pollution source diffusion simulation (PSDS) software  
  
PSDS软件是基于ANSYS Fluent二次开发研发，用于对污染源扩散模拟计算和分析，该软件操作简便，有简要模式和专家模式两种模式，满足不同用户需求。  
一、软件运行环境 
 
1. 安装ANSYS 191.1软件，具体安装教程请参看作者博客 https://blog.csdn.net/qq_34720818/article/details/106177673

二、案例介绍  

下面以一个案例介绍该软件的操作过程。  
1. 案例介绍  
模拟计算研究区域中污染源释放氯气一分钟的扩散过程。  

2. 案例研究区域  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/0.png)  

3. 打开PSDS软件  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/1.png)  

4. 选择简要模式，打开参数设置，填写工程名，选择网格文件（在源代码的TestData文件夹中有案例的网格文件）  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/2.png)  

5. 勾选扩散是否随时间变化复选框，设置污染源材料为氯气  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/3.png)  

6. 选择网格文件后，程序会自动识别风速入口边界及污染源区域，可分别对边界进行设置，设置每个边界后注意及时点击保存按钮  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/4.png)  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/5.png)  
 
7. 点击迭代求解，弹出【迭代求解】窗口，设置时间步个数为60，设置完成后直接关闭【迭代求解】窗口即可  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/6.png)  

8. 点击计算机结果导出，弹出【计算结果导出】窗口，选择创建 Z轴6m处截面，点击创建按钮，然后再下拉列表选中z_6，操作完成后直接关闭【计算结果导出】窗口即可  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/7.png)  

9. 点击确定按钮，完成参数设置（如果工程已近存在，会提示是否替换当前工程数据），然后点击关闭按钮，关闭简要模式窗口  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/8.png)   

10. 点击PSDS软件中计算求解按钮，弹出【执行计算】窗口，设置核数，点击确定，开始计算  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/9.png)  

11. 计算完成，会在工程目录下的PicData文件夹生成结果图  
![image]( https://github.com/Mekeater/PSDS/blob/master/OperatePicture/10.png)  

12. 结果展示功能,待更新...

13. 专家模式操作,待更新...