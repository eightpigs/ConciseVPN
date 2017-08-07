# ConciseVPN


## 简介

> 使用C#写的windows 下快捷管理VPN工具

> 可以实现对本地VPN的增加,修改,删除管理


## 使用

> 由于对C#不是很熟悉,新增vpn时需要给名称前面添加 vpn 作为前缀 ... 

> 鼠标悬停在每一个功能按钮都有相应提示.操作非常简单.

> 鼠标移开窗体会自动隐藏,在屏幕的右上方显示当前状态线.(已连接:绿色   未连接:红色)

> 工具条固定在屏幕有上方.X轴大约在屏幕3/4的地方.

> 提供一个VPN列表和用户信息列表(VPN的帐号),VPN列表是通过获取系统的adsl连接

> 用户列表可以多个,具体在程序启动目录的app.config里面配置user节点.


## 截图

VPN连接成功,在屏幕右上方显示的绿色状态条(不要说你看不到....)
![连接成功](/Screenshot/Screenshot_1.png)



鼠标放到状态条显示的软件主界面
![主界面](/Screenshot/Screenshot_2.png)



VPN和用户列表
![主界面的VPN/用户列表](/Screenshot/Screenshot_3.png)


VPN未连接状态
![未连接](/Screenshot/Screenshot_4.png)




