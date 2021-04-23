# Algorithm-Implementation

## Initial Public Offerring (Braze Version)

        A company registers an IPO on a website sellshares.com. All the shares  on the this website are available
        for bidding for a particular time frame called the bidding window. At the end of the bidding window an aution
        logic is used to decide how many of the available shares go to which bidder until all the shares that are available
        have been allotted or all the bidders have bidders have received the shares they bid for,
        whichever comes earlier. 

        The bids arrive from the users in the firm of <userId, number of shares, bidding pricem timestamp> until the bidding window is closed
        The acton logic assigns shares to the bidders as follows:
        1.) The bidder with the highest price gets the number of shares they bid for
        2.) if multpile bidders have bid at the same price the bidders are assigned shares in the order in which they places their bids (earliest bids first)