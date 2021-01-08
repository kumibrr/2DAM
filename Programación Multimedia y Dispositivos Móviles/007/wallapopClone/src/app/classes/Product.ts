import { UserInfo } from './UserInfo';

export class Product {

    public name: string;
    public description: string;
    public price: number;
    public currency: string;
    public datePublished: Date;
    public dateUpdated: Date;
    public user: UserInfo;
    public location: string;
    public hasBeenSold: boolean;
    public imageUrl: string;

    constructor(
        name: string,
        description: string,
        price: number,
        currency: string,
        datePublished: Date,
        dateUpdated: Date,
        user: UserInfo,
        location: string,
        hasBeenSold: boolean,
        imageUrl: string
    ) {
        this.name = name;
        this.description = description;
        this.price = price;
        this.currency = currency;
        this.datePublished = datePublished;
        this.dateUpdated = dateUpdated;
        this.user = user;
        this.location = location;
        this.hasBeenSold = hasBeenSold;
        this.imageUrl = imageUrl;
    }
}
