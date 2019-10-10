public class Main {
        public static void main(String[] args)
        {
            StringBuffer sb = new StringBuffer("Reverse Me!");
            inPlaceReverse(sb);
            System.out.println(sb);
        }

        public static void inPlaceReverse(StringBuffer s){
            int begin = 0, end = s.length() - 1;

            while (!(begin >= end)){
                s.setCharAt(begin, (char)(s.charAt(begin) ^ s.charAt(end)));
                s.setCharAt(end, (char)(s.charAt(begin) ^ s.charAt(end)));
                s.setCharAt(begin, (char)(s.charAt(begin) ^ s.charAt(end)));
                begin++;
                end--;
            }

        }

}

