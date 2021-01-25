use MindBox;

select productName, category.CategoryName from product
join  ProductCategory on  ProductCategory.productId = product.Id
join  category on  ProductCategory.categoryId = category.id
union 
select productName, null from product
join  ProductCategory on  ProductCategory.productId = product.Id
where ProductCategory.categoryId is null
