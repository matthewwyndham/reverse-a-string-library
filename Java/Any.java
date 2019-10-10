public class Main {
        public static void main(String[] args)
        {
            String s = "Reverse Me!";
            StringBuilder sb = new StringBuilder(s);
            s = sb.reverse().toString();

            System.out.println(s);
        }

}

