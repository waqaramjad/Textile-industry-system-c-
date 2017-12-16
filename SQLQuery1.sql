--select * from manager

use ISE_WIM


select * from yarn_recipt 

insert into yarn_receipt(YR_Date,YR_Brand,YR_Count,YR_Bags_Recvd,YR_Date_Recvd,YR_DescriptionM_ID,YR_Status,Contract_PO_nmbr)
values ('12/16/2010','AL Mehboob Textile','24 CTN','110','12/18/2010','received all of them',101,'Done',8465)


alter table Yarn_receipt add Contract_PO_nmbr int

alter table Yarn_receipt drop column YR_DO_No , YR_Reciever


select * from Yarn_receipt



