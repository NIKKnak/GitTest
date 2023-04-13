__ Создайте таблицу с мобильными телефонами (mobile_phones), используя графический интерфейс. Заполните БД данными. Добавьте скриншот на платформу в качестве ответа на ДЗ __







-- SELECT product_name, manufacturer, price FROM telephone
-- WHERE product_count  > 2;



-- Если ассортимент - это наименование модели, то вот так)) если нет то *
-- SELECT product_name FROM telephone
-- WHERE manufacturer = "Samsung";


-- SELECT * FROM telephone
-- WHERE product_name LIKE 'Iphone %%%'


-- SELECT * FROM telephone
-- WHERE manufacturer LIKE 'Samsung'


SELECT * FROM telephone
WHERE product_name LIKE '%[^0-9]%'