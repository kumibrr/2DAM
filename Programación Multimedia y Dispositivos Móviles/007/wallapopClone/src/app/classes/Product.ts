import { UserInfo } from './UserInfo';

export class Product {

    public name: string;
    public description: string;
    public price: number;
    public currency: string;
    public datePublished: Date;
    public dateUpdated: Date;
    public user: UserInfo;
    public latitude: number;
    public longitude: number;
    public hasBeenSold: boolean;
    public imageUrl: string[];

    constructor(
        name: string,
        description: string,
        price: number,
        currency: string,
        datePublished: Date,
        dateUpdated: Date,
        user: UserInfo,
        latitude: number,
        longitude: number,
        hasBeenSold: boolean,
        imageUrl: string[]
    ) {
        this.name = name;
        this.description = description;
        this.price = price;
        this.currency = currency;
        this.datePublished = datePublished;
        this.dateUpdated = dateUpdated;
        this.user = user;
        this.latitude = latitude;
        this.longitude = longitude;
        this.hasBeenSold = hasBeenSold;
        this.imageUrl = imageUrl;
    }
}
