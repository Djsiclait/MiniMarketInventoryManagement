declare @results varchar(500)

select @results = COALESCE(@results + ';', '') + convert(varchar(100), A.fld_product_key)
From
	Tbl_Products as A 
where
	A.fld_product_name Like '%' + '2%' + '%'
order by
	A.fld_product_key

select @results

Select 
	--A.fld_product_id,
	--A.fld_product_key,
	--COALESCE(A.fld_product_key + ';', '') as test,
	--@results,
	A.fld_product_name,
	B.fld_brand_name,
	--A.fld_product_unit,
	Max(A.fld_product_unit_price),
	Sum(A.fld_product_quantity)
From
	Tbl_Products as A 
left join Tbl_Product_Brands as B on B.fld_brand_id = A.fld_product_brand
Where
	fld_product_discontinued = 0
--and (
--	A.fld_product_key Like '%' + @key_word + '%' or
--	A.fld_product_name Like '%' + @key_word + '%' or
--	B.fld_brand_name Like '%' + @key_word + '%'
--	)
Group By
	COALESCE(A.fld_product_key + ';', ''),
	A.fld_product_name,
	B.fld_brand_name,
	A.fld_product_unit_price
Order By 
	fld_product_name



