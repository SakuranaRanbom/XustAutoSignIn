package domain;

public class User {
    private String uid;
    private String gh;
    private String name;
    private String phone;
    private String in = "1";
    private String email;
    public User() {

    }

    public User(String uid, String gh, String name, String phone, String in, String email) {
        this.uid = uid;
        this.gh = gh;
        this.name = name;
        this.phone = phone;
        this.in = in;
        this.email = email;
    }

    public String getUid() {
        return uid;
    }

    public void setUid(String uid) {
        this.uid = uid;
    }

    public String getGh() {
        return gh;
    }

    public void setGh(String gh) {
        this.gh = gh;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getIn() {
        return in;
    }

    public void setIn(String in) {
        this.in = in;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    @Override
    public String toString() {
        return "User{" +
                "uid='" + uid + '\'' +
                ", gh='" + gh + '\'' +
                ", name='" + name + '\'' +
                ", phone='" + phone + '\'' +
                ", in='" + in + '\'' +
                ", email='" + email + '\'' +
                '}';
    }
}
