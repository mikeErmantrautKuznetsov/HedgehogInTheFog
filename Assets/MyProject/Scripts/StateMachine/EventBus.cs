using System;

public class EventBus
{
    private static Lazy <EventBus> _instance;

    public static Lazy <EventBus> Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Lazy<EventBus>();

            return _instance;
        }
    }

    public Action OnRan;
    public Action OnIdle;
    public Action OnJumped;
    public Action OnAttacked;
    public Action OnDied;
    public Action OnDesktop;
    public Action OnMobile;
    public Action OnMethodMovePlayer;
    public Action OnMethodJumpPlayer;
    public Action OnTouchDeadZona;
}
