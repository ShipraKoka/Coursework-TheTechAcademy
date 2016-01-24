from datetime import datetime
from pytz import timezone


def timeNY():
    now_utc = datetime.now(timezone('UTC'))
    now_NY = now_utc.astimezone(timezone('US/Eastern'))
    if now_NY.hour < 9 or now_NY.hour > 20:
        print "The New York office is currently closed."
    else:
        print "The New York office is currently open."
    print "It is now", now_NY.strftime("%I:%M %p"), "in New York.\n"

def timeLondon():
    now_utc = datetime.now(timezone('UTC'))
    now_london = now_utc.astimezone(timezone('Europe/London'))
    if now_london.hour < 9 or now_london.hour > 20:
        print "The London office is currently closed."
    else:
        print "The London office is currently open."
    print "It is now", now_london.strftime("%I:%M %p"), "in London."


timeNY()
timeLondon()



