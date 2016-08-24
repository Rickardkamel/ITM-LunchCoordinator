import { IEmployee } from './';
import { IRestaurant } from './';

export interface ILunch {
    id: number;
    lunchTime: Date;
    restaurantId: number;
    employees: IEmployee[];
    restaurant: IRestaurant;
}