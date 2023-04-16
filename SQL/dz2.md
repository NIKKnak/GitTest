USE lesson_1;
CREATE TABLE sales(
id SERIAL PRIMARY KEY,
order_date YEAR NOT NULL,
count_product INT
);


INSERT INTO sales(order_date,count_product)
VALUES 
(2022-01-01, 156),
(2022-01-02,180),
(2022-01-03,21),
(2022-01-04,124),
(2022-01-05,341);


SELECT * FROM sales;