namespace MeetingApp.Models{

    public static class Repository{

        private static List<UserInfo> _users = new();


        static Repository()
        {
            _users.Add(new UserInfo(){Id=1,Name="Ali",Phone="22222",Email="abc@gmail.com",WillAttend=true});
            _users.Add(new UserInfo(){Id=2,Name="Ahmet",Phone="232222",Email="abce@gmail.com",WillAttend=false});
            _users.Add(new UserInfo(){Id=3,Name="Asım",Phone="224222",Email="abcd@gmail.com",WillAttend=true});
        }
        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){
            user.Id=Users.Count+1; // yeni kaydın id sini otomatik kayıt sayısı+1 yapma
            _users.Add(user);
        }

        public static UserInfo? GetById(int id){ // null olabilecegi icin ? koyduk
            return _users.FirstOrDefault(user =>user.Id==id); // parametredeki id user ıd ye esitse dondurur
        }
    }
}