SELECT
	b.ID,
	NumberOfTopics = count(t.ID)
FROM
	Bookstore.Book b
	LEFT JOIN Bookstore.BookTopic t on t.BookID = b.ID
GROUP BY
b.ID