Insert Into Tbl_User_Activity_Logs
(
	fld_user_activity_username,
	fld_user_activity_description,
	fld_user_activity_type
)
Values
(
	'p.siclait',
	'User, p.siclait, logged into the system successfully',
	'LOG IN'
),
(
	'p.siclait',
	'User, p.siclait, viewed the inventory browser',
	'BASIC ACCESS'
),
(
	'p.siclait',
	'Error occured while registering new product',
	'ERROR'
),
(
	'p.siclait',
	'User, p.siclait, logged out the system successfully',
	'LOG OUT'
)







