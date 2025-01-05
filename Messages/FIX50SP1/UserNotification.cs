// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class UserNotification : Message
{
    public const string MsgType = "CB";

    public UserNotification() : base()
    {
        Header.SetField(new MsgType("CB"));
    }

    public UserNotification(
            UserStatus aUserStatus
        ) : this()
    {
        UserStatus = aUserStatus;
    }

    public Username Username
    {
        get
        {
            Username val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Username val) { Username = val; }
    public Username Get(Username val) { GetField(val); return val; }
    public bool IsSet(Username val) { return IsSetUsername(); }
    public bool IsSetUsername() { return IsSetField(Tags.Username); }

    public UserStatus UserStatus
    {
        get
        {
            UserStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UserStatus val) { UserStatus = val; }
    public UserStatus Get(UserStatus val) { GetField(val); return val; }
    public bool IsSet(UserStatus val) { return IsSetUserStatus(); }
    public bool IsSetUserStatus() { return IsSetField(Tags.UserStatus); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }
}
