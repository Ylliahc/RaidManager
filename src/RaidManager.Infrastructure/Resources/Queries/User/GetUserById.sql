SELECT 
    u.name,
    u.creation_date
FROM User u
WHERE u.user_id = @Id