select p.Product_name from TableProduct p inner join TableProductCategory t on p.ProductTypelD = t.Product_Category_ID 
where t.Product_Type_Name = ;
select * from TableProduct;

select p.product_name from TableProduct p inner join TableProductCategory t on
p.ProductTypeID = t.Product_Category_ID where t.Product_Type_Name = 'printer';



select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join tableproductcategory b on 
a.product_gst_id = b.product_gst_id where b.Product_Type_Name ='printer';



select price from tableproduct where product_name='Apple'