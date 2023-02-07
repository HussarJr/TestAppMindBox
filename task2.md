В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
1) Select * from products join categories on products.id = categories.products_id 
![image](https://user-images.githubusercontent.com/63926083/217253382-9d953a25-a9aa-4ae5-bf2b-fcc5ae8fb36f.png)

2) Select * from products join ProductCategories on products.id = ProductCategories.products_id join categories on ProductCategories.category_id = categories.id

![image](https://user-images.githubusercontent.com/63926083/217253460-b1819bed-3b0d-45a9-a2e7-e53f912fd906.png)
