using Discount.Grpc.Protos;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtoServ.DiscountProtoServClient _discountProtoServ;

        public DiscountGrpcService(DiscountProtoServ.DiscountProtoServClient discountProtoServ)
        {
            _discountProtoServ = discountProtoServ;
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest { ProductName = productName };
            return await _discountProtoServ.GetDiscountAsync(discountRequest);
        }
    }
}
