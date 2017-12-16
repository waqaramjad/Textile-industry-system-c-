--create database SecondWala


create database WAW_Textile


--Dusri waali hai 


create table Manager1(
Manager_ID int not null primary key identity(100,1),
Manager_Name nvarchar(50) not null,
Manager_FatherName nvarchar(30) not null,
Manager_CNIC nvarchar(20) check (Manager_CNIC like '[0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]') not null,
Manager_StartDate datetime not null,
Manager_EndDate datetime not null,
Manager_Contact nvarchar(30) not null,
Manager_Email nvarchar(30),
Manager_AuthLevel nvarchar(50),
Manager_Type nvarchar(30) not null,
Manager_Username nvarchar(30) unique not null,
Manager_Password nvarchar(30) unique not null,                
Manager_Address nvarchar(max),
Manager_Status nvarchar(30))

--alter table PackingList add Manager_ID int 








create table Client1(
Client_ID int not null primary key identity(100,1),
Client_Name nvarchar(50) not null,
Client_Title nvarchar(50) not null,
Client_StartDate nvarchar(10) check (Client_StartDate like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]') not null,
Client_EndDate nvarchar(10) check (Client_EndDate like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]') not null,
Client_Contact nvarchar(30),
Client_Email nvarchar(30),
Client_Address nvarchar(max),
Client_CompanyName nvarchar(80),
Client_Status nvarchar(30))

create table Production_Report(
PR_ID int primary key identity(200,1) not null,
PR_Date nvarchar(10) check (PR_Date like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]') not null,
PR_Month nvarchar(30),
PR_Duration nvarchar(20),
PR_Efficiency decimal (18,2),
PR_Description nvarchar(max),
PR_TotalUnit int,
PR_Average numeric(10,2),
M_ID int,
PRd_ID int,
PR_Status nvarchar(30))



create table PackingList(
PL_ID int not null primary key identity(100,1),
PLI_ID int,
PL_Date datetime,
PL_Party nvarchar(50),
PL_Seller nvarchar(100),
PL_Quality nvarchar(max),
PL_Total_Mtr int,
PL_TotalPeice int,
PL_Vehicle_no nvarchar(30),
PL_Remarks nvarchar(50),
M_ID int,
PL_Status nvarchar(50))




create table PackingList_LineItem(
PLLI_ID int primary key identity(400,1) not null,
PL_ID int,
PLLI_Quantity int,
PLLI_Description nvarchar(50),
PLLI_Status nvarchar(50))




create table ProductionReport_LineItem(
PRd_ID int primary key identity (500,1) not null,
PR_ID int not null,
PRd_Date nvarchar (10) check(PRd_Date like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'),
PR_Loom_No nvarchar (10) not null,
PRd_Shift nvarchar (30) not null,
PRd_Status nvarchar (30) ,
PRd_Description nvarchar(40),
PRd_Unit int not null)


create table Item_Yarn(
Yarn_ID int primary key identity (600,1),
Yarn_Brand nvarchar (30) not null,
Yarn_Quality nvarchar (30) not null,
Yarn_Count decimal (10,2) not null,
Yarn_Weight decimal (10,2) not null, 
Yarn_No_of_Bags nvarchar (30) not null,
Yarn_Quantity nvarchar (50) not null,
Yarn_DO_No nvarchar (30) not null,
Yarn_Received_Date nvarchar (10) check(Yarn_Received_Date like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'),
Yarn_Description nvarchar (60) not null,
PRd_ID int,
Yarn_Status nvarchar (30) not null) 


 
 create table QWIR_LineItem (
 QWd_ID int primary key identity (700,1) not null,
 QWd_ nvarchar (50) not null,
 QWd_Date nvarchar (8) check(QWd_Date like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'),
 QWd_Rejection nvarchar (30),
 QWd_Fresh nvarchar (50) not null,
 QWd_Rej_Recvd nvarchar (30) not null ,
 QWd_Rej_Bal nvarchar (30) not null ,
 QWd_Description nvarchar (30) not null,
 M_ID int,
 QW_ID int,
 QWd_Status nvarchar (30) not null,)



 create table Mending_Report(
 MR_ID int primary key identity (800,1) not null,
 MR_Date nvarchar (8) check(MR_Date like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'),
 MR_Lot_No nvarchar (30) not null,
 MR_Total_Length nvarchar (30) not null,
 MR_Fresh nvarchar (50) not null,
 MR_Rejection nvarchar (50),
 MR_Rej_Percent decimal (10,2) ,
 MR_Description nvarchar (100),
 C_ID int,
 MR_Status nvarchar (30)) 



 create table [Challan_D/O] (
 Challan_ID int primary key identity (900,1),
 Challan_Date nvarchar (8) check(Challan_Date like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'),
 Challan_Number nvarchar (30) not null,
 Challan_Quality nvarchar (30) not null,
 Challan_Contract_No nvarchar (30) ,
 Challan_Brand nvarchar (30) ,
 Challan_weight nvarchar(30),
 C_ID int,
 M_ID int,
 Challan_Quantity nvarchar (50),
 Challan_Status nvarchar (30))



 create table QWIR(
 QW_ID int primary key identity (1000,1),
 QW_Quality nvarchar (30) not null,
 QW_Month nvarchar (20) not null,
 QW_Contract_No nvarchar (20) not null,
 QW_Buyer nvarchar (20) not null ,
 QW_Status nvarchar (20)  ,
 M_ID int,
 MR_ID int )



 create table [Invoice1](
 I_ID int  not null primary key identity (1100,1) ,
 I_Date nvarchar (8) check(I_Date like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'),
 I_Serial_No nvarchar (20) not null,
 I_total_Amount numeric(18,2) not null,
 I_Contract_No nvarchar (40) not null,
 I_Description nvarchar (60) not null,
 IDt_ID int,
 M_ID int,
 I_Status nvarchar (30) not null,)




 create table Yarn_Receipt(
 YR_ID int not  null primary key identity (1200,1),
 YR_Date datetime,
 YR_Brand nvarchar (50),
 YR_Count decimal (16,2),
 YR_Bags_Recvd nvarchar (50) ,
 YR_DO_No nvarchar (50) ,
 YR_Date_Recvd datetime ,
 YR_Description nvarchar (50) ,
 YR_Reciever nvarchar(50),
 M_ID int,
 YR_Status nvarchar (50))




 
 create table Item_GreyCloth(
IGC_ID int not null primary key identity (1400,1),
IGC_Brand nvarchar(30) not null,
IGC_Description nvarchar (50) ,
IGC_Status nvarchar (30) not null,
IGC_Quality nvarchar (50) not null,
IGC_Count nvarchar(50) not null,
M_ID int,
PL_ID int,
IGC_Length int)

  

create table Buyer (
Buyer_ID int not null primary key identity (1500,1) ,
Buyer_Name nvarchar (30) not null,
Buyer_Address nvarchar(30) not null,
Buyer_NTN_No_ int not null,
Buyer_ST_Reg_No nvarchar(40),
Buyer_Description nvarchar (30))



create table Sizing1(
Sizing_ID int not null primary key identity(1600,1),
Sizing_no_Beams int not null,
Sizing_PartyName nvarchar(40),
Sizing_Date nvarchar(10) check(Sizing_Date like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'),
Sizing_Bags int not null,
Sizing_Set_no int not null,
Sizing_YarnCount nvarchar(40),
M_ID int,
Sizing_Textile nvarchar(30),
Sizing_TotalLength numeric(10,2))






create table Sizing_Return_LineItem(
SR_lineitem_ID int not null primary key identity(1800,1),
SR_lineitem_Beam_No int not null,
SR_lineitem_DeliverTo nvarchar(30) not null,
SR_lineitem_Length nvarchar(30) not null,
SR_lineitem_seriel int not null)




create table [contract1](
Contract_ID int not null primary key identity(100,1),
Contract_month_start nvarchar(40),
Contract_month_end nvarchar(40),
Contract_date datetime,
Contract_payment_term nvarchar(100),
Contract_Delievery_term nvarchar(100),
Contract_loom_size nvarchar(20),
Contract_no_of_looms int,
Contract_item_name nvarchar(60),
Contract_description nvarchar(max),
Contract_Rate_per_Mtr decimal(18,2),
Contract_Total_cost decimal(18,2),
M_ID int,
C_ID int,
Contract_Remarks nvarchar(max))



create table DeliverySchedule(
DSchedule_ID int not null primary key identity(100,1),
Contract_ID int,
DSchedule_Quantity nvarchar(40),
DSchedule_Date datetime)


create table LoomType(
Loom_ID int not null primary key identity(100,1),
Loom_Type nvarchar(40))


create table [Shift](
Shift_ID int not null primary key identity(100,1),
Shift_Type nvarchar(40))


create table Brand(
Brand_ID int not null primary key identity(100,1),
Brand_name nvarchar(50))



